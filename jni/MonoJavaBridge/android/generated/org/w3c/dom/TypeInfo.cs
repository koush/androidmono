namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.TypeInfo_))]
	public interface TypeInfo  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getTypeName();
		global::java.lang.String getTypeNamespace();
		bool isDerivedFrom(java.lang.String arg0, java.lang.String arg1, int arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.TypeInfo))]
	public sealed partial class TypeInfo_ : java.lang.Object, TypeInfo
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TypeInfo_()
		{
			InitJNI();
		}
		internal TypeInfo_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getTypeName28021;
		 global::java.lang.String org.w3c.dom.TypeInfo.getTypeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.TypeInfo_._getTypeName28021)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.TypeInfo_.staticClass, global::org.w3c.dom.TypeInfo_._getTypeName28021)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTypeNamespace28022;
		 global::java.lang.String org.w3c.dom.TypeInfo.getTypeNamespace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.TypeInfo_._getTypeNamespace28022)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.TypeInfo_.staticClass, global::org.w3c.dom.TypeInfo_._getTypeNamespace28022)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDerivedFrom28023;
		 bool org.w3c.dom.TypeInfo.isDerivedFrom(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.TypeInfo_._isDerivedFrom28023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.TypeInfo_.staticClass, global::org.w3c.dom.TypeInfo_._isDerivedFrom28023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.TypeInfo_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/TypeInfo"));
			global::org.w3c.dom.TypeInfo_._getTypeName28021 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.TypeInfo_.staticClass, "getTypeName", "()Ljava/lang/String;");
			global::org.w3c.dom.TypeInfo_._getTypeNamespace28022 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.TypeInfo_.staticClass, "getTypeNamespace", "()Ljava/lang/String;");
			global::org.w3c.dom.TypeInfo_._isDerivedFrom28023 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.TypeInfo_.staticClass, "isDerivedFrom", "(Ljava/lang/String;Ljava/lang/String;I)Z");
		}
	}
}
