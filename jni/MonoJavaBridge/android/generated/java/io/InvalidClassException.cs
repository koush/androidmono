namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidClassException : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InvalidClassException()
		{
			InitJNI();
		}
		protected InvalidClassException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage18999;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.InvalidClassException._getMessage18999)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.InvalidClassException.staticClass, global::java.io.InvalidClassException._getMessage18999)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _InvalidClassException19000;
		public InvalidClassException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InvalidClassException.staticClass, global::java.io.InvalidClassException._InvalidClassException19000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidClassException19001;
		public InvalidClassException(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InvalidClassException.staticClass, global::java.io.InvalidClassException._InvalidClassException19001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _classname19002;
		public global::java.lang.String classname
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _classname19002)) as java.lang.String;
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InvalidClassException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InvalidClassException"));
			global::java.io.InvalidClassException._getMessage18999 = @__env.GetMethodIDNoThrow(global::java.io.InvalidClassException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.io.InvalidClassException._InvalidClassException19000 = @__env.GetMethodIDNoThrow(global::java.io.InvalidClassException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.InvalidClassException._InvalidClassException19001 = @__env.GetMethodIDNoThrow(global::java.io.InvalidClassException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.io.InvalidClassException._classname19002 = @__env.GetFieldIDNoThrow(global::java.io.InvalidClassException.staticClass, "classname", "Ljava/lang/String;");
		}
	}
}
