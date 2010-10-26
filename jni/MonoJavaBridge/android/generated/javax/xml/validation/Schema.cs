namespace javax.xml.validation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.validation.Schema_))]
	public abstract partial class Schema : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Schema()
		{
			InitJNI();
		}
		protected Schema(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newValidator31179;
		public abstract global::javax.xml.validation.Validator newValidator();
		internal static global::MonoJavaBridge.MethodId _newValidatorHandler31180;
		public abstract global::javax.xml.validation.ValidatorHandler newValidatorHandler();
		internal static global::MonoJavaBridge.MethodId _Schema31181;
		protected Schema()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.validation.Schema.staticClass, global::javax.xml.validation.Schema._Schema31181);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.Schema.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/Schema"));
			global::javax.xml.validation.Schema._newValidator31179 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Schema.staticClass, "newValidator", "()Ljavax/xml/validation/Validator;");
			global::javax.xml.validation.Schema._newValidatorHandler31180 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Schema.staticClass, "newValidatorHandler", "()Ljavax/xml/validation/ValidatorHandler;");
			global::javax.xml.validation.Schema._Schema31181 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Schema.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.validation.Schema))]
	internal sealed partial class Schema_ : javax.xml.validation.Schema
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Schema_()
		{
			InitJNI();
		}
		internal Schema_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newValidator31182;
		public override global::javax.xml.validation.Validator newValidator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.Schema_._newValidator31182)) as javax.xml.validation.Validator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.Schema_.staticClass, global::javax.xml.validation.Schema_._newValidator31182)) as javax.xml.validation.Validator;
		}
		internal static global::MonoJavaBridge.MethodId _newValidatorHandler31183;
		public override global::javax.xml.validation.ValidatorHandler newValidatorHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.validation.Schema_._newValidatorHandler31183)) as javax.xml.validation.ValidatorHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.validation.Schema_.staticClass, global::javax.xml.validation.Schema_._newValidatorHandler31183)) as javax.xml.validation.ValidatorHandler;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.validation.Schema_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/validation/Schema"));
			global::javax.xml.validation.Schema_._newValidator31182 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Schema_.staticClass, "newValidator", "()Ljavax/xml/validation/Validator;");
			global::javax.xml.validation.Schema_._newValidatorHandler31183 = @__env.GetMethodIDNoThrow(global::javax.xml.validation.Schema_.staticClass, "newValidatorHandler", "()Ljavax/xml/validation/ValidatorHandler;");
		}
	}
}
