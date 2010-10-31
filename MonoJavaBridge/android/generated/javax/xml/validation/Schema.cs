namespace javax.xml.validation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.validation.Schema_))]
	public abstract partial class Schema : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Schema(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::javax.xml.validation.Validator newValidator();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::javax.xml.validation.ValidatorHandler newValidatorHandler();
		private static global::MonoJavaBridge.MethodId _m2;
		protected Schema() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.Schema._m2.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.Schema._m2 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Schema.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.Schema.staticClass, global::javax.xml.validation.Schema._m2);
			Init(@__env, handle);
		}
		static Schema()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.Schema.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/Schema"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.validation.Schema))]
	internal sealed partial class Schema_ : javax.xml.validation.Schema
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Schema_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::javax.xml.validation.Validator newValidator()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.Schema_.staticClass, "newValidator", "()Ljavax/xml/validation/Validator;", ref global::javax.xml.validation.Schema_._m0) as javax.xml.validation.Validator;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::javax.xml.validation.ValidatorHandler newValidatorHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.validation.Schema_.staticClass, "newValidatorHandler", "()Ljavax/xml/validation/ValidatorHandler;", ref global::javax.xml.validation.Schema_._m1) as javax.xml.validation.ValidatorHandler;
		}
		static Schema_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.Schema_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/Schema"));
		}
	}
}
