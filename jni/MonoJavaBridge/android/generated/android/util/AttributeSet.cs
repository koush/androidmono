namespace android.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.util.AttributeSet_))]
	public interface AttributeSet  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class AttributeSet_ : java.lang.Object, AttributeSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AttributeSet_()
		{
			InitJNI();
		}
		internal AttributeSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue13614;
		 global::java.lang.String android.util.AttributeSet.getAttributeValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeValue13614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeValue13614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue13615;
		 global::java.lang.String android.util.AttributeSet.getAttributeValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeValue13615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeValue13615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeCount13616;
		 int android.util.AttributeSet.getAttributeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeCount13616);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeCount13616);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeName13617;
		 global::java.lang.String android.util.AttributeSet.getAttributeName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeName13617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeName13617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPositionDescription13618;
		 global::java.lang.String android.util.AttributeSet.getPositionDescription() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.AttributeSet_._getPositionDescription13618)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getPositionDescription13618)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNameResource13619;
		 int android.util.AttributeSet.getAttributeNameResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeNameResource13619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeNameResource13619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeListValue13620;
		 int android.util.AttributeSet.getAttributeListValue(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeListValue13620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeListValue13620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeListValue13621;
		 int android.util.AttributeSet.getAttributeListValue(int arg0, java.lang.String[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeListValue13621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeListValue13621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeBooleanValue13622;
		 bool android.util.AttributeSet.getAttributeBooleanValue(java.lang.String arg0, java.lang.String arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeBooleanValue13622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeBooleanValue13622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeBooleanValue13623;
		 bool android.util.AttributeSet.getAttributeBooleanValue(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeBooleanValue13623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeBooleanValue13623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeResourceValue13624;
		 int android.util.AttributeSet.getAttributeResourceValue(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeResourceValue13624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeResourceValue13624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeResourceValue13625;
		 int android.util.AttributeSet.getAttributeResourceValue(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeResourceValue13625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeResourceValue13625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeIntValue13626;
		 int android.util.AttributeSet.getAttributeIntValue(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeIntValue13626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeIntValue13626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeIntValue13627;
		 int android.util.AttributeSet.getAttributeIntValue(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeIntValue13627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeIntValue13627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeUnsignedIntValue13628;
		 int android.util.AttributeSet.getAttributeUnsignedIntValue(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeUnsignedIntValue13628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeUnsignedIntValue13628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeUnsignedIntValue13629;
		 int android.util.AttributeSet.getAttributeUnsignedIntValue(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeUnsignedIntValue13629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeUnsignedIntValue13629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeFloatValue13630;
		 float android.util.AttributeSet.getAttributeFloatValue(java.lang.String arg0, java.lang.String arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeFloatValue13630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeFloatValue13630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeFloatValue13631;
		 float android.util.AttributeSet.getAttributeFloatValue(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeFloatValue13631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeFloatValue13631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getIdAttribute13632;
		 global::java.lang.String android.util.AttributeSet.getIdAttribute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.AttributeSet_._getIdAttribute13632)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getIdAttribute13632)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getClassAttribute13633;
		 global::java.lang.String android.util.AttributeSet.getClassAttribute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.AttributeSet_._getClassAttribute13633)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getClassAttribute13633)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIdAttributeResourceValue13634;
		 int android.util.AttributeSet.getIdAttributeResourceValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getIdAttributeResourceValue13634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getIdAttributeResourceValue13634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStyleAttribute13635;
		 int android.util.AttributeSet.getStyleAttribute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getStyleAttribute13635);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getStyleAttribute13635);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.AttributeSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/AttributeSet"));
			global::android.util.AttributeSet_._getAttributeValue13614 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeValue", "(I)Ljava/lang/String;");
			global::android.util.AttributeSet_._getAttributeValue13615 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.util.AttributeSet_._getAttributeCount13616 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeCount", "()I");
			global::android.util.AttributeSet_._getAttributeName13617 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeName", "(I)Ljava/lang/String;");
			global::android.util.AttributeSet_._getPositionDescription13618 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getPositionDescription", "()Ljava/lang/String;");
			global::android.util.AttributeSet_._getAttributeNameResource13619 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeNameResource", "(I)I");
			global::android.util.AttributeSet_._getAttributeListValue13620 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeListValue", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;I)I");
			global::android.util.AttributeSet_._getAttributeListValue13621 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeListValue", "(I[Ljava/lang/String;I)I");
			global::android.util.AttributeSet_._getAttributeBooleanValue13622 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeBooleanValue", "(Ljava/lang/String;Ljava/lang/String;Z)Z");
			global::android.util.AttributeSet_._getAttributeBooleanValue13623 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeBooleanValue", "(IZ)Z");
			global::android.util.AttributeSet_._getAttributeResourceValue13624 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeResourceValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.util.AttributeSet_._getAttributeResourceValue13625 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeResourceValue", "(II)I");
			global::android.util.AttributeSet_._getAttributeIntValue13626 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeIntValue", "(II)I");
			global::android.util.AttributeSet_._getAttributeIntValue13627 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.util.AttributeSet_._getAttributeUnsignedIntValue13628 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeUnsignedIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.util.AttributeSet_._getAttributeUnsignedIntValue13629 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeUnsignedIntValue", "(II)I");
			global::android.util.AttributeSet_._getAttributeFloatValue13630 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeFloatValue", "(Ljava/lang/String;Ljava/lang/String;F)F");
			global::android.util.AttributeSet_._getAttributeFloatValue13631 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeFloatValue", "(IF)F");
			global::android.util.AttributeSet_._getIdAttribute13632 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getIdAttribute", "()Ljava/lang/String;");
			global::android.util.AttributeSet_._getClassAttribute13633 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getClassAttribute", "()Ljava/lang/String;");
			global::android.util.AttributeSet_._getIdAttributeResourceValue13634 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getIdAttributeResourceValue", "(I)I");
			global::android.util.AttributeSet_._getStyleAttribute13635 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getStyleAttribute", "()I");
		}
	}
}
