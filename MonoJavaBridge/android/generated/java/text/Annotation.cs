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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.Annotation.staticClass, "toString", "()Ljava/lang/String;", ref global::java.text.Annotation._toString25157) as java.lang.String;
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.Annotation.staticClass, "getValue", "()Ljava/lang/Object;", ref global::java.text.Annotation._getValue25158) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _Annotation25159;
		public Annotation(java.lang.Object arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Annotation._Annotation25159.native == global::System.IntPtr.Zero)
				global::java.text.Annotation._Annotation25159 = @__env.GetMethodIDNoThrow(global::java.text.Annotation.staticClass, "<init>", "(Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.Annotation.staticClass, global::java.text.Annotation._Annotation25159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Annotation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.Annotation.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/Annotation"));
		}
		internal static void InitJNI()
		{
		}
	}
}
