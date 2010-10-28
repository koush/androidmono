namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidClassException : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		internal static global::MonoJavaBridge.MethodId _getMessage19117;
		public override global::java.lang.String getMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.InvalidClassException._getMessage19117)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.InvalidClassException.staticClass, global::java.io.InvalidClassException._getMessage19117)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _InvalidClassException19118;
		public InvalidClassException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InvalidClassException.staticClass, global::java.io.InvalidClassException._InvalidClassException19118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidClassException19119;
		public InvalidClassException(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InvalidClassException.staticClass, global::java.io.InvalidClassException._InvalidClassException19119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _classname19120;
		public global::java.lang.String classname
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _classname19120)) as java.lang.String;
			}
			set
			{
			}
		}
		static InvalidClassException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InvalidClassException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InvalidClassException"));
			global::java.io.InvalidClassException._getMessage19117 = @__env.GetMethodIDNoThrow(global::java.io.InvalidClassException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.io.InvalidClassException._InvalidClassException19118 = @__env.GetMethodIDNoThrow(global::java.io.InvalidClassException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.InvalidClassException._InvalidClassException19119 = @__env.GetMethodIDNoThrow(global::java.io.InvalidClassException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.io.InvalidClassException._classname19120 = @__env.GetFieldIDNoThrow(global::java.io.InvalidClassException.staticClass, "classname", "Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}
