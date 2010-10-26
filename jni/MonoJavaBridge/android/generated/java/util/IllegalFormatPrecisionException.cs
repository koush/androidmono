namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalFormatPrecisionException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IllegalFormatPrecisionException()
		{
			InitJNI();
		}
		protected IllegalFormatPrecisionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage26321;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IllegalFormatPrecisionException._getMessage26321)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IllegalFormatPrecisionException.staticClass, global::java.util.IllegalFormatPrecisionException._getMessage26321)) as java.lang.String;
		}
		public new int Precision
		{
			get
			{
				return getPrecision();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrecision26322;
		public virtual int getPrecision() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.IllegalFormatPrecisionException._getPrecision26322);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.IllegalFormatPrecisionException.staticClass, global::java.util.IllegalFormatPrecisionException._getPrecision26322);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalFormatPrecisionException26323;
		public IllegalFormatPrecisionException(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IllegalFormatPrecisionException.staticClass, global::java.util.IllegalFormatPrecisionException._IllegalFormatPrecisionException26323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.IllegalFormatPrecisionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/IllegalFormatPrecisionException"));
			global::java.util.IllegalFormatPrecisionException._getMessage26321 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatPrecisionException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.util.IllegalFormatPrecisionException._getPrecision26322 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatPrecisionException.staticClass, "getPrecision", "()I");
			global::java.util.IllegalFormatPrecisionException._IllegalFormatPrecisionException26323 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatPrecisionException.staticClass, "<init>", "(I)V");
		}
	}
}
