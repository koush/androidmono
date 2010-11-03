namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CodingErrorAction : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CodingErrorAction(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.CodingErrorAction.staticClass, "toString", "()Ljava/lang/String;", ref global::java.nio.charset.CodingErrorAction._m0) as java.lang.String;
		}
		internal static global::MonoJavaBridge.FieldId _IGNORE6518;
		public static global::java.nio.charset.CodingErrorAction IGNORE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.charset.CodingErrorAction.staticClass, _IGNORE6518)) as java.nio.charset.CodingErrorAction;
			}
		}
		internal static global::MonoJavaBridge.FieldId _REPLACE6519;
		public static global::java.nio.charset.CodingErrorAction REPLACE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.charset.CodingErrorAction.staticClass, _REPLACE6519)) as java.nio.charset.CodingErrorAction;
			}
		}
		internal static global::MonoJavaBridge.FieldId _REPORT6520;
		public static global::java.nio.charset.CodingErrorAction REPORT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.charset.CodingErrorAction.staticClass, _REPORT6520)) as java.nio.charset.CodingErrorAction;
			}
		}
		static CodingErrorAction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CodingErrorAction.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CodingErrorAction"));
			global::java.nio.charset.CodingErrorAction._IGNORE6518 = @__env.GetStaticFieldIDNoThrow(global::java.nio.charset.CodingErrorAction.staticClass, "IGNORE", "Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CodingErrorAction._REPLACE6519 = @__env.GetStaticFieldIDNoThrow(global::java.nio.charset.CodingErrorAction.staticClass, "REPLACE", "Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CodingErrorAction._REPORT6520 = @__env.GetStaticFieldIDNoThrow(global::java.nio.charset.CodingErrorAction.staticClass, "REPORT", "Ljava/nio/charset/CodingErrorAction;");
		}
	}
}
