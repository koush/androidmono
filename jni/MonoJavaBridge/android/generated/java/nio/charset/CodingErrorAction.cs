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
		internal static global::MonoJavaBridge.MethodId _toString22690;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CodingErrorAction._toString22690)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CodingErrorAction.staticClass, global::java.nio.charset.CodingErrorAction._toString22690)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.FieldId _IGNORE22691;
		public static global::java.nio.charset.CodingErrorAction IGNORE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.charset.CodingErrorAction.staticClass, _IGNORE22691)) as java.nio.charset.CodingErrorAction;
			}
		}
		internal static global::MonoJavaBridge.FieldId _REPLACE22692;
		public static global::java.nio.charset.CodingErrorAction REPLACE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.charset.CodingErrorAction.staticClass, _REPLACE22692)) as java.nio.charset.CodingErrorAction;
			}
		}
		internal static global::MonoJavaBridge.FieldId _REPORT22693;
		public static global::java.nio.charset.CodingErrorAction REPORT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.charset.CodingErrorAction.staticClass, _REPORT22693)) as java.nio.charset.CodingErrorAction;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CodingErrorAction.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CodingErrorAction"));
			global::java.nio.charset.CodingErrorAction._toString22690 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CodingErrorAction.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.charset.CodingErrorAction._IGNORE22691 = @__env.GetStaticFieldIDNoThrow(global::java.nio.charset.CodingErrorAction.staticClass, "IGNORE", "Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CodingErrorAction._REPLACE22692 = @__env.GetStaticFieldIDNoThrow(global::java.nio.charset.CodingErrorAction.staticClass, "REPLACE", "Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CodingErrorAction._REPORT22693 = @__env.GetStaticFieldIDNoThrow(global::java.nio.charset.CodingErrorAction.staticClass, "REPORT", "Ljava/nio/charset/CodingErrorAction;");
		}
	}
}
