namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class URISyntaxException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static URISyntaxException()
		{
			InitJNI();
		}
		protected URISyntaxException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage21755;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URISyntaxException._getMessage21755)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URISyntaxException.staticClass, global::java.net.URISyntaxException._getMessage21755)) as java.lang.String;
		}
		public new int Index
		{
			get
			{
				return getIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndex21756;
		public virtual int getIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URISyntaxException._getIndex21756);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URISyntaxException.staticClass, global::java.net.URISyntaxException._getIndex21756);
		}
		public new global::java.lang.String Input
		{
			get
			{
				return getInput();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInput21757;
		public virtual global::java.lang.String getInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URISyntaxException._getInput21757)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URISyntaxException.staticClass, global::java.net.URISyntaxException._getInput21757)) as java.lang.String;
		}
		public new global::java.lang.String Reason
		{
			get
			{
				return getReason();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReason21758;
		public virtual global::java.lang.String getReason() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URISyntaxException._getReason21758)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URISyntaxException.staticClass, global::java.net.URISyntaxException._getReason21758)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _URISyntaxException21759;
		public URISyntaxException(java.lang.String arg0, java.lang.String arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URISyntaxException.staticClass, global::java.net.URISyntaxException._URISyntaxException21759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URISyntaxException21760;
		public URISyntaxException(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URISyntaxException.staticClass, global::java.net.URISyntaxException._URISyntaxException21760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URISyntaxException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URISyntaxException"));
			global::java.net.URISyntaxException._getMessage21755 = @__env.GetMethodIDNoThrow(global::java.net.URISyntaxException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.net.URISyntaxException._getIndex21756 = @__env.GetMethodIDNoThrow(global::java.net.URISyntaxException.staticClass, "getIndex", "()I");
			global::java.net.URISyntaxException._getInput21757 = @__env.GetMethodIDNoThrow(global::java.net.URISyntaxException.staticClass, "getInput", "()Ljava/lang/String;");
			global::java.net.URISyntaxException._getReason21758 = @__env.GetMethodIDNoThrow(global::java.net.URISyntaxException.staticClass, "getReason", "()Ljava/lang/String;");
			global::java.net.URISyntaxException._URISyntaxException21759 = @__env.GetMethodIDNoThrow(global::java.net.URISyntaxException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;I)V");
			global::java.net.URISyntaxException._URISyntaxException21760 = @__env.GetMethodIDNoThrow(global::java.net.URISyntaxException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
