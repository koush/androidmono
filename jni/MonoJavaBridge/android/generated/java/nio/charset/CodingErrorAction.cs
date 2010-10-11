namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CodingErrorAction : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CodingErrorAction()
		{
			InitJNI();
		}
		protected CodingErrorAction(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString14758;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CodingErrorAction._toString14758)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CodingErrorAction.staticClass, global::java.nio.charset.CodingErrorAction._toString14758)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.FieldId _IGNORE14759;
		public static global::java.nio.charset.CodingErrorAction IGNORE
		{
			get
			{
				return default(global::java.nio.charset.CodingErrorAction);
			}
		}
		internal static global::MonoJavaBridge.FieldId _REPLACE14760;
		public static global::java.nio.charset.CodingErrorAction REPLACE
		{
			get
			{
				return default(global::java.nio.charset.CodingErrorAction);
			}
		}
		internal static global::MonoJavaBridge.FieldId _REPORT14761;
		public static global::java.nio.charset.CodingErrorAction REPORT
		{
			get
			{
				return default(global::java.nio.charset.CodingErrorAction);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CodingErrorAction.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CodingErrorAction"));
			global::java.nio.charset.CodingErrorAction._toString14758 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CodingErrorAction.staticClass, "toString", "()Ljava/lang/String;");
		}
	}
}
