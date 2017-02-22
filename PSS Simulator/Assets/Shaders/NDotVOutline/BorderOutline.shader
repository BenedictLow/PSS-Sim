// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

Shader "Unlit/BorderOutline"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		_Color ("Color", Color) = (1,1,1,1)
		_Prominance ("Prominance", FLOAT) = 0
	}
	SubShader
	{
		Tags 
		{
			"Queue" = "Transparent" 
			"RenderType"="Opaque" 
			"XRay" = "ColoredOutline"
		}
		LOD 100

					Blend One One
			ZWrite Off
			ZTest Always

		Stencil
		{
			Ref 0
			Comp NotEqual
		}

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			// make fog work
			#pragma multi_compile_fog
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
				float3 normal : NORMAL;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float3 viewDir : FLOAT;
				float3 normal : NORMAL;
				UNITY_FOG_COORDS(1)
				float4 vertex : SV_POSITION;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;
			float4 _Color;
			float _Prominance;

			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);
				o.normal = UnityObjectToWorldNormal(v.normal);
				o.viewDir = normalize(_WorldSpaceCameraPos.xyz - mul(unity_ObjectToWorld, v.vertex).xyz);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				//UNITY_TRANSFER_FOG(o,o.vertex);
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
				
				// sample the texture
				//fixed4 col = tex2D(_MainTex, i.uv) * _Color;
				// apply fog
				//UNITY_APPLY_FOG(i.fogCoord, col);
				float ndotv = 1 - dot(i.normal, i.viewDir) * 2;
				float4 col = float4(ndotv, ndotv, ndotv, 0) * _Color * _Prominance * _Color.a;
				return col;
			}
			ENDCG
		}
	}
}
