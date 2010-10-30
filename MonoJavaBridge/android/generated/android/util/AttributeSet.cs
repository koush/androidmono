namespace android.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.util.AttributeSet_))]
	public partial interface AttributeSet  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getAttributeValue(int arg0);
		global::java.lang.String getAttributeValue(java.lang.String arg0, java.lang.String arg1);
		int getAttributeCount();
		global::java.lang.String getAttributeName(int arg0);
		global::java.lang.String getPositionDescription();
		int getAttributeNameResource(int arg0);
		int getAttributeListValue(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, int arg3);
		int getAttributeListValue(int arg0, java.lang.String[] arg1, int arg2);
		bool getAttributeBooleanValue(java.lang.String arg0, java.lang.String arg1, bool arg2);
		bool getAttributeBooleanValue(int arg0, bool arg1);
		int getAttributeResourceValue(java.lang.String arg0, java.lang.String arg1, int arg2);
		int getAttributeResourceValue(int arg0, int arg1);
		int getAttributeIntValue(int arg0, int arg1);
		int getAttributeIntValue(java.lang.String arg0, java.lang.String arg1, int arg2);
		int getAttributeUnsignedIntValue(java.lang.String arg0, java.lang.String arg1, int arg2);
		int getAttributeUnsignedIntValue(int arg0, int arg1);
		float getAttributeFloatValue(java.lang.String arg0, java.lang.String arg1, float arg2);
		float getAttributeFloatValue(int arg0, float arg1);
		global::java.lang.String getIdAttribute();
		global::java.lang.String getClassAttribute();
		int getIdAttributeResourceValue(int arg0);
		int getStyleAttribute();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.util.AttributeSet))]
	internal sealed partial class AttributeSet_ : java.lang.Object, AttributeSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AttributeSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String android.util.AttributeSet.getAttributeValue(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.util.AttributeSet_.staticClass, "getAttributeValue", "(I)Ljava/lang/String;", ref global::android.util.AttributeSet_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String android.util.AttributeSet.getAttributeValue(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.util.AttributeSet_.staticClass, "getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::android.util.AttributeSet_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int android.util.AttributeSet.getAttributeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.AttributeSet_.staticClass, "getAttributeCount", "()I", ref global::android.util.AttributeSet_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String android.util.AttributeSet.getAttributeName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.util.AttributeSet_.staticClass, "getAttributeName", "(I)Ljava/lang/String;", ref global::android.util.AttributeSet_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.String android.util.AttributeSet.getPositionDescription()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.util.AttributeSet_.staticClass, "getPositionDescription", "()Ljava/lang/String;", ref global::android.util.AttributeSet_._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		int android.util.AttributeSet.getAttributeNameResource(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.AttributeSet_.staticClass, "getAttributeNameResource", "(I)I", ref global::android.util.AttributeSet_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		int android.util.AttributeSet.getAttributeListValue(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.AttributeSet_.staticClass, "getAttributeListValue", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;I)I", ref global::android.util.AttributeSet_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		int android.util.AttributeSet.getAttributeListValue(int arg0, java.lang.String[] arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.AttributeSet_.staticClass, "getAttributeListValue", "(I[Ljava/lang/String;I)I", ref global::android.util.AttributeSet_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		bool android.util.AttributeSet.getAttributeBooleanValue(java.lang.String arg0, java.lang.String arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.util.AttributeSet_.staticClass, "getAttributeBooleanValue", "(Ljava/lang/String;Ljava/lang/String;Z)Z", ref global::android.util.AttributeSet_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		bool android.util.AttributeSet.getAttributeBooleanValue(int arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.util.AttributeSet_.staticClass, "getAttributeBooleanValue", "(IZ)Z", ref global::android.util.AttributeSet_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		int android.util.AttributeSet.getAttributeResourceValue(java.lang.String arg0, java.lang.String arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.AttributeSet_.staticClass, "getAttributeResourceValue", "(Ljava/lang/String;Ljava/lang/String;I)I", ref global::android.util.AttributeSet_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		int android.util.AttributeSet.getAttributeResourceValue(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.AttributeSet_.staticClass, "getAttributeResourceValue", "(II)I", ref global::android.util.AttributeSet_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		int android.util.AttributeSet.getAttributeIntValue(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.AttributeSet_.staticClass, "getAttributeIntValue", "(II)I", ref global::android.util.AttributeSet_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		int android.util.AttributeSet.getAttributeIntValue(java.lang.String arg0, java.lang.String arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.AttributeSet_.staticClass, "getAttributeIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I", ref global::android.util.AttributeSet_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		int android.util.AttributeSet.getAttributeUnsignedIntValue(java.lang.String arg0, java.lang.String arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.AttributeSet_.staticClass, "getAttributeUnsignedIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I", ref global::android.util.AttributeSet_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		int android.util.AttributeSet.getAttributeUnsignedIntValue(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.AttributeSet_.staticClass, "getAttributeUnsignedIntValue", "(II)I", ref global::android.util.AttributeSet_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		float android.util.AttributeSet.getAttributeFloatValue(java.lang.String arg0, java.lang.String arg1, float arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.util.AttributeSet_.staticClass, "getAttributeFloatValue", "(Ljava/lang/String;Ljava/lang/String;F)F", ref global::android.util.AttributeSet_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		float android.util.AttributeSet.getAttributeFloatValue(int arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.util.AttributeSet_.staticClass, "getAttributeFloatValue", "(IF)F", ref global::android.util.AttributeSet_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		global::java.lang.String android.util.AttributeSet.getIdAttribute()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.util.AttributeSet_.staticClass, "getIdAttribute", "()Ljava/lang/String;", ref global::android.util.AttributeSet_._m18) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		global::java.lang.String android.util.AttributeSet.getClassAttribute()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.util.AttributeSet_.staticClass, "getClassAttribute", "()Ljava/lang/String;", ref global::android.util.AttributeSet_._m19) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		int android.util.AttributeSet.getIdAttributeResourceValue(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.AttributeSet_.staticClass, "getIdAttributeResourceValue", "(I)I", ref global::android.util.AttributeSet_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		int android.util.AttributeSet.getStyleAttribute()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.AttributeSet_.staticClass, "getStyleAttribute", "()I", ref global::android.util.AttributeSet_._m21);
		}
		static AttributeSet_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.AttributeSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/AttributeSet"));
		}
		internal static void InitJNI()
		{
		}
	}
}
