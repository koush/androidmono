namespace javax.xml.validation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.validation.Schema_))]
	public abstract partial class Schema : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Schema(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newValidator31180;
		public abstract global::javax.xml.validation.Validator newValidator();
		internal static global::MonoJavaBridge.MethodId _newValidatorHandler31181;
		public abstract global::javax.xml.validation.ValidatorHandler newValidatorHandler();
		internal static global::MonoJavaBridge.MethodId _Schema31182;
		protected Schema() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.Schema._Schema31182.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.Schema._Schema31182 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Schema.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.Schema.staticClass, global::javax.xml.validation.Schema._Schema31182);
			Init(@__env, handle);
		}
		static Schema()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.Schema.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/Schema"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.validation.Schema))]
	internal sealed partial class Schema_ : javax.xml.validation.Schema
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Schema_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newValidator31183;
		public override global::javax.xml.validation.Validator newValidator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.Schema_._newValidator31183.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.Schema_._newValidator31183 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Schema_.staticClass, "newValidator", "()Ljavax/xml/validation/Validator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.Schema_._newValidator31183)) as javax.xml.validation.Validator;
		}
		internal static global::MonoJavaBridge.MethodId _newValidatorHandler31184;
		public override global::javax.xml.validation.ValidatorHandler newValidatorHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.validation.Schema_._newValidatorHandler31184.native == global::System.IntPtr.Zero)
				global::javax.xml.validation.Schema_._newValidatorHandler31184 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Schema_.staticClass, "newValidatorHandler", "()Ljavax/xml/validation/ValidatorHandler;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.Schema_._newValidatorHandler31184)) as javax.xml.validation.ValidatorHandler;
		}
		static Schema_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.Schema_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/Schema"));
		}
		internal static void InitJNI()
		{
		}
	}
}
