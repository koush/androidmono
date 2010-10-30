namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CodingErrorAction : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CodingErrorAction(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString22809;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.CodingErrorAction.staticClass, "toString", "()Ljava/lang/String;", ref global::java.nio.charset.CodingErrorAction._toString22809) as java.lang.String;
		}
		internal static global::MonoJavaBridge.FieldId _IGNORE22810;
		public static global::java.nio.charset.CodingErrorAction IGNORE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.charset.CodingErrorAction.staticClass, _IGNORE22810)) as java.nio.charset.CodingErrorAction;
			}
		}
		internal static global::MonoJavaBridge.FieldId _REPLACE22811;
		public static global::java.nio.charset.CodingErrorAction REPLACE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.charset.CodingErrorAction.staticClass, _REPLACE22811)) as java.nio.charset.CodingErrorAction;
			}
		}
		internal static global::MonoJavaBridge.FieldId _REPORT22812;
		public static global::java.nio.charset.CodingErrorAction REPORT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.charset.CodingErrorAction.staticClass, _REPORT22812)) as java.nio.charset.CodingErrorAction;
			}
		}
		static CodingErrorAction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CodingErrorAction.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CodingErrorAction"));
			global::java.nio.charset.CodingErrorAction._IGNORE22810 = @__env.GetStaticFieldIDNoThrow(global::java.nio.charset.CodingErrorAction.staticClass, "IGNORE", "Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CodingErrorAction._REPLACE22811 = @__env.GetStaticFieldIDNoThrow(global::java.nio.charset.CodingErrorAction.staticClass, "REPLACE", "Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CodingErrorAction._REPORT22812 = @__env.GetStaticFieldIDNoThrow(global::java.nio.charset.CodingErrorAction.staticClass, "REPORT", "Ljava/nio/charset/CodingErrorAction;");
		}
		internal static void InitJNI()
		{
		}
	}
}
