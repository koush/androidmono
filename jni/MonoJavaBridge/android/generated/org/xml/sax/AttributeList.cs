namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.AttributeList_))]
	public interface AttributeList  : global::MonoJavaBridge.IJavaObject 
	{
		int getLength();
		global::java.lang.String getName(int arg0);
		global::java.lang.String getValue(int arg0);
		global::java.lang.String getValue(java.lang.String arg0);
		global::java.lang.String getType(int arg0);
		global::java.lang.String getType(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.AttributeList))]
	public sealed partial class AttributeList_ : java.lang.Object, AttributeList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AttributeList_()
		{
			InitJNI();
		}
		internal AttributeList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLength34825;
		 int org.xml.sax.AttributeList.getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.AttributeList_._getLength34825);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.AttributeList_.staticClass, global::org.xml.sax.AttributeList_._getLength34825);
		}
		internal static global::MonoJavaBridge.MethodId _getName34826;
		 global::java.lang.String org.xml.sax.AttributeList.getName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.AttributeList_._getName34826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.AttributeList_.staticClass, global::org.xml.sax.AttributeList_._getName34826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue34827;
		 global::java.lang.String org.xml.sax.AttributeList.getValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.AttributeList_._getValue34827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.AttributeList_.staticClass, global::org.xml.sax.AttributeList_._getValue34827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue34828;
		 global::java.lang.String org.xml.sax.AttributeList.getValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.AttributeList_._getValue34828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.AttributeList_.staticClass, global::org.xml.sax.AttributeList_._getValue34828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType34829;
		 global::java.lang.String org.xml.sax.AttributeList.getType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.AttributeList_._getType34829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.AttributeList_.staticClass, global::org.xml.sax.AttributeList_._getType34829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType34830;
		 global::java.lang.String org.xml.sax.AttributeList.getType(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.AttributeList_._getType34830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.AttributeList_.staticClass, global::org.xml.sax.AttributeList_._getType34830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.AttributeList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/AttributeList"));
			global::org.xml.sax.AttributeList_._getLength34825 = @__env.GetMethodIDNoThrow(global::org.xml.sax.AttributeList_.staticClass, "getLength", "()I");
			global::org.xml.sax.AttributeList_._getName34826 = @__env.GetMethodIDNoThrow(global::org.xml.sax.AttributeList_.staticClass, "getName", "(I)Ljava/lang/String;");
			global::org.xml.sax.AttributeList_._getValue34827 = @__env.GetMethodIDNoThrow(global::org.xml.sax.AttributeList_.staticClass, "getValue", "(I)Ljava/lang/String;");
			global::org.xml.sax.AttributeList_._getValue34828 = @__env.GetMethodIDNoThrow(global::org.xml.sax.AttributeList_.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.AttributeList_._getType34829 = @__env.GetMethodIDNoThrow(global::org.xml.sax.AttributeList_.staticClass, "getType", "(I)Ljava/lang/String;");
			global::org.xml.sax.AttributeList_._getType34830 = @__env.GetMethodIDNoThrow(global::org.xml.sax.AttributeList_.staticClass, "getType", "(Ljava/lang/String;)Ljava/lang/String;");
		}
	}
}
