namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Date : java.util.Date
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Date()
		{
			InitJNI();
		}
		protected Date(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString18815;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Date._toString18815)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Date.staticClass, global::java.sql.Date._toString18815)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf18816;
		public static global::java.sql.Date valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.sql.Date.staticClass, global::java.sql.Date._valueOf18816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _setTime18817;
		public override void setTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Date._setTime18817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Date.staticClass, global::java.sql.Date._setTime18817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Hours
		{
			get
			{
				return getHours();
			}
			set
			{
				setHours(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHours18818;
		public override int getHours() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Date._getHours18818);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Date.staticClass, global::java.sql.Date._getHours18818);
		}
		public new int Minutes
		{
			get
			{
				return getMinutes();
			}
			set
			{
				setMinutes(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinutes18819;
		public override int getMinutes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Date._getMinutes18819);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Date.staticClass, global::java.sql.Date._getMinutes18819);
		}
		public new int Seconds
		{
			get
			{
				return getSeconds();
			}
			set
			{
				setSeconds(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSeconds18820;
		public override int getSeconds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Date._getSeconds18820);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Date.staticClass, global::java.sql.Date._getSeconds18820);
		}
		internal static global::MonoJavaBridge.MethodId _setHours18821;
		public override void setHours(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Date._setHours18821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Date.staticClass, global::java.sql.Date._setHours18821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinutes18822;
		public override void setMinutes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Date._setMinutes18822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Date.staticClass, global::java.sql.Date._setMinutes18822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSeconds18823;
		public override void setSeconds(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Date._setSeconds18823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Date.staticClass, global::java.sql.Date._setSeconds18823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Date18824;
		public Date(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.Date.staticClass, global::java.sql.Date._Date18824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date18825;
		public Date(long arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.Date.staticClass, global::java.sql.Date._Date18825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Date.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Date"));
			global::java.sql.Date._toString18815 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "toString", "()Ljava/lang/String;");
			global::java.sql.Date._valueOf18816 = @__env.GetStaticMethodIDNoThrow(global::java.sql.Date.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/sql/Date;");
			global::java.sql.Date._setTime18817 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "setTime", "(J)V");
			global::java.sql.Date._getHours18818 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "getHours", "()I");
			global::java.sql.Date._getMinutes18819 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "getMinutes", "()I");
			global::java.sql.Date._getSeconds18820 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "getSeconds", "()I");
			global::java.sql.Date._setHours18821 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "setHours", "(I)V");
			global::java.sql.Date._setMinutes18822 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "setMinutes", "(I)V");
			global::java.sql.Date._setSeconds18823 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "setSeconds", "(I)V");
			global::java.sql.Date._Date18824 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "<init>", "(III)V");
			global::java.sql.Date._Date18825 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "<init>", "(J)V");
		}
	}
}
