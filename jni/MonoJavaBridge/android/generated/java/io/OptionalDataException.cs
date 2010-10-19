namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OptionalDataException : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OptionalDataException()
		{
			InitJNI();
		}
		protected OptionalDataException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.FieldId _length13730;
		public int length
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _eof13731;
		public bool eof
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.OptionalDataException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/OptionalDataException"));
		}
	}
}
