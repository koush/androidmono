namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Annotation : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Annotation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString25157;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.Annotation._toString25157)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.Annotation.staticClass, global::java.text.Annotation._toString25157)) as java.lang.String;
		}
		public new global::java.lang.Object Value
		{
			get
			{
				return getValue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValue25158;
		public virtual global::java.lang.Object getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.Annotation._getValue25158)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.Annotation.staticClass, global::java.text.Annotation._getValue25158)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _Annotation25159;
		public Annotation(java.lang.Object arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.Annotation.staticClass, global::java.text.Annotation._Annotation25159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Annotation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.Annotation.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/Annotation"));
			global::java.text.Annotation._toString25157 = @__env.GetMethodIDNoThrow(global::java.text.Annotation.staticClass, "toString", "()Ljava/lang/String;");
			global::java.text.Annotation._getValue25158 = @__env.GetMethodIDNoThrow(global::java.text.Annotation.staticClass, "getValue", "()Ljava/lang/Object;");
			global::java.text.Annotation._Annotation25159 = @__env.GetMethodIDNoThrow(global::java.text.Annotation.staticClass, "<init>", "(Ljava/lang/Object;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
