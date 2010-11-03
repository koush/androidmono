namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DataTruncation : java.sql.SQLWarning
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DataTruncation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Index
		{
			get
			{
				return getIndex();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DataTruncation.staticClass, "getIndex", "()I", ref global::java.sql.DataTruncation._m0);
		}
		public new bool Parameter
		{
			get
			{
				return getParameter();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool getParameter()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DataTruncation.staticClass, "getParameter", "()Z", ref global::java.sql.DataTruncation._m1);
		}
		public new int DataSize
		{
			get
			{
				return getDataSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getDataSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DataTruncation.staticClass, "getDataSize", "()I", ref global::java.sql.DataTruncation._m2);
		}
		public new bool Read
		{
			get
			{
				return getRead();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool getRead()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DataTruncation.staticClass, "getRead", "()Z", ref global::java.sql.DataTruncation._m3);
		}
		public new int TransferSize
		{
			get
			{
				return getTransferSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getTransferSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DataTruncation.staticClass, "getTransferSize", "()I", ref global::java.sql.DataTruncation._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public DataTruncation(int arg0, bool arg1, bool arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DataTruncation._m5.native == global::System.IntPtr.Zero)
				global::java.sql.DataTruncation._m5 = @__env.GetMethodIDNoThrow(global::java.sql.DataTruncation.staticClass, "<init>", "(IZZII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.DataTruncation.staticClass, global::java.sql.DataTruncation._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public DataTruncation(int arg0, bool arg1, bool arg2, int arg3, int arg4, java.lang.Throwable arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DataTruncation._m6.native == global::System.IntPtr.Zero)
				global::java.sql.DataTruncation._m6 = @__env.GetMethodIDNoThrow(global::java.sql.DataTruncation.staticClass, "<init>", "(IZZIILjava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.DataTruncation.staticClass, global::java.sql.DataTruncation._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		static DataTruncation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.DataTruncation.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/DataTruncation"));
		}
	}
}
