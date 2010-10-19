namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DataTruncation : java.sql.SQLWarning
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DataTruncation()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getIndex18637;
		public virtual int getIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DataTruncation._getIndex18637);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DataTruncation.staticClass, global::java.sql.DataTruncation._getIndex18637);
		}
		public new bool Parameter
		{
			get
			{
				return getParameter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameter18638;
		public virtual bool getParameter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DataTruncation._getParameter18638);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DataTruncation.staticClass, global::java.sql.DataTruncation._getParameter18638);
		}
		public new int DataSize
		{
			get
			{
				return getDataSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDataSize18639;
		public virtual int getDataSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DataTruncation._getDataSize18639);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DataTruncation.staticClass, global::java.sql.DataTruncation._getDataSize18639);
		}
		public new bool Read
		{
			get
			{
				return getRead();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRead18640;
		public virtual bool getRead() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DataTruncation._getRead18640);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DataTruncation.staticClass, global::java.sql.DataTruncation._getRead18640);
		}
		public new int TransferSize
		{
			get
			{
				return getTransferSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTransferSize18641;
		public virtual int getTransferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DataTruncation._getTransferSize18641);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DataTruncation.staticClass, global::java.sql.DataTruncation._getTransferSize18641);
		}
		internal static global::MonoJavaBridge.MethodId _DataTruncation18642;
		public DataTruncation(int arg0, bool arg1, bool arg2, int arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.DataTruncation.staticClass, global::java.sql.DataTruncation._DataTruncation18642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DataTruncation18643;
		public DataTruncation(int arg0, bool arg1, bool arg2, int arg3, int arg4, java.lang.Throwable arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.DataTruncation.staticClass, global::java.sql.DataTruncation._DataTruncation18643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.DataTruncation.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/DataTruncation"));
			global::java.sql.DataTruncation._getIndex18637 = @__env.GetMethodIDNoThrow(global::java.sql.DataTruncation.staticClass, "getIndex", "()I");
			global::java.sql.DataTruncation._getParameter18638 = @__env.GetMethodIDNoThrow(global::java.sql.DataTruncation.staticClass, "getParameter", "()Z");
			global::java.sql.DataTruncation._getDataSize18639 = @__env.GetMethodIDNoThrow(global::java.sql.DataTruncation.staticClass, "getDataSize", "()I");
			global::java.sql.DataTruncation._getRead18640 = @__env.GetMethodIDNoThrow(global::java.sql.DataTruncation.staticClass, "getRead", "()Z");
			global::java.sql.DataTruncation._getTransferSize18641 = @__env.GetMethodIDNoThrow(global::java.sql.DataTruncation.staticClass, "getTransferSize", "()I");
			global::java.sql.DataTruncation._DataTruncation18642 = @__env.GetMethodIDNoThrow(global::java.sql.DataTruncation.staticClass, "<init>", "(IZZII)V");
			global::java.sql.DataTruncation._DataTruncation18643 = @__env.GetMethodIDNoThrow(global::java.sql.DataTruncation.staticClass, "<init>", "(IZZIILjava/lang/Throwable;)V");
		}
	}
}
