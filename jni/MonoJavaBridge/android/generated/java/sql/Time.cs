namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Time : java.util.Date
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Time()
		{
			InitJNI();
		}
		protected Time(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString19274;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Time._toString19274)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Time.staticClass, global::java.sql.Time._toString19274)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf19275;
		public static global::java.sql.Time valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.sql.Time.staticClass, global::java.sql.Time._valueOf19275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _setTime19276;
		public override void setTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Time._setTime19276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Time.staticClass, global::java.sql.Time._setTime19276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Year
		{
			get
			{
				return getYear();
			}
			set
			{
				setYear(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getYear19277;
		public override int getYear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Time._getYear19277);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Time.staticClass, global::java.sql.Time._getYear19277);
		}
		public new int Month
		{
			get
			{
				return getMonth();
			}
			set
			{
				setMonth(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMonth19278;
		public override int getMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Time._getMonth19278);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Time.staticClass, global::java.sql.Time._getMonth19278);
		}
		public new int Date
		{
			get
			{
				return getDate();
			}
			set
			{
				setDate(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDate19279;
		public override int getDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Time._getDate19279);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Time.staticClass, global::java.sql.Time._getDate19279);
		}
		internal static global::MonoJavaBridge.MethodId _setDate19280;
		public override void setDate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Time._setDate19280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Time.staticClass, global::java.sql.Time._setDate19280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMonth19281;
		public override void setMonth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Time._setMonth19281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Time.staticClass, global::java.sql.Time._setMonth19281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setYear19282;
		public override void setYear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Time._setYear19282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Time.staticClass, global::java.sql.Time._setYear19282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Day
		{
			get
			{
				return getDay();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDay19283;
		public override int getDay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Time._getDay19283);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Time.staticClass, global::java.sql.Time._getDay19283);
		}
		internal static global::MonoJavaBridge.MethodId _Time19284;
		public Time(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.Time.staticClass, global::java.sql.Time._Time19284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Time19285;
		public Time(long arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.Time.staticClass, global::java.sql.Time._Time19285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Time.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Time"));
			global::java.sql.Time._toString19274 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "toString", "()Ljava/lang/String;");
			global::java.sql.Time._valueOf19275 = @__env.GetStaticMethodIDNoThrow(global::java.sql.Time.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/sql/Time;");
			global::java.sql.Time._setTime19276 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "setTime", "(J)V");
			global::java.sql.Time._getYear19277 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "getYear", "()I");
			global::java.sql.Time._getMonth19278 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "getMonth", "()I");
			global::java.sql.Time._getDate19279 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "getDate", "()I");
			global::java.sql.Time._setDate19280 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "setDate", "(I)V");
			global::java.sql.Time._setMonth19281 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "setMonth", "(I)V");
			global::java.sql.Time._setYear19282 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "setYear", "(I)V");
			global::java.sql.Time._getDay19283 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "getDay", "()I");
			global::java.sql.Time._Time19284 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "<init>", "(III)V");
			global::java.sql.Time._Time19285 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "<init>", "(J)V");
		}
	}
}
