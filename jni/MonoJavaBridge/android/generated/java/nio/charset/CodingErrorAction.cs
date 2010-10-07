namespace java.nio.charset
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class CodingErrorAction : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static CodingErrorAction()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.charset.CodingErrorAction), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.nio.charset.CodingErrorAction(@__env);
			}
		}
		protected CodingErrorAction(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13146;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CodingErrorAction._toString13146));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CodingErrorAction.staticClass, global::java.nio.charset.CodingErrorAction._toString13146));
		}
		internal static global::net.sf.jni4net.jni.FieldId _IGNORE13147;
		public static global::java.nio.charset.CodingErrorAction IGNORE
		{
			get
			{
				return default(global::java.nio.charset.CodingErrorAction);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _REPLACE13148;
		public static global::java.nio.charset.CodingErrorAction REPLACE
		{
			get
			{
				return default(global::java.nio.charset.CodingErrorAction);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _REPORT13149;
		public static global::java.nio.charset.CodingErrorAction REPORT
		{
			get
			{
				return default(global::java.nio.charset.CodingErrorAction);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.charset.CodingErrorAction.staticClass = @__class;
			global::java.nio.charset.CodingErrorAction._toString13146 = @__env.GetMethodID(global::java.nio.charset.CodingErrorAction.staticClass, "toString", "()Ljava/lang/String;");
		}
	}
}
