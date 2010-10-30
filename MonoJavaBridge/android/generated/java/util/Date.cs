namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Date : java.lang.Object, java.io.Serializable, java.lang.Cloneable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Date(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Date.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.Date._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Date.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.Date._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, "hashCode", "()I", ref global::java.util.Date._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Date.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.Date._m3) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int compareTo(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, "compareTo", "(Ljava/util/Date;)I", ref global::java.util.Date._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.util.Date._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool after(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Date.staticClass, "after", "(Ljava/util/Date;)Z", ref global::java.util.Date._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool before(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Date.staticClass, "before", "(Ljava/util/Date;)Z", ref global::java.util.Date._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static long parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._m8.native == global::System.IntPtr.Zero)
				global::java.util.Date._m8 = @__env.GetStaticMethodIDNoThrow(global::java.util.Date.staticClass, "parse", "(Ljava/lang/String;)J");
			return @__env.CallStaticLongMethod(java.util.Date.staticClass, global::java.util.Date._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setTime(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Date.staticClass, "setTime", "(J)V", ref global::java.util.Date._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long Time
		{
			get
			{
				return getTime();
			}
			set
			{
				setTime(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual long getTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.Date.staticClass, "getTime", "()J", ref global::java.util.Date._m10);
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
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getYear()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, "getYear", "()I", ref global::java.util.Date._m11);
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
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int getMonth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, "getMonth", "()I", ref global::java.util.Date._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int getDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, "getDate", "()I", ref global::java.util.Date._m13);
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
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int getHours()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, "getHours", "()I", ref global::java.util.Date._m14);
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
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int getMinutes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, "getMinutes", "()I", ref global::java.util.Date._m15);
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
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int getSeconds()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, "getSeconds", "()I", ref global::java.util.Date._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static long UTC(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._m17.native == global::System.IntPtr.Zero)
				global::java.util.Date._m17 = @__env.GetStaticMethodIDNoThrow(global::java.util.Date.staticClass, "UTC", "(IIIIII)J");
			return @__env.CallStaticLongMethod(java.util.Date.staticClass, global::java.util.Date._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setDate(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Date.staticClass, "setDate", "(I)V", ref global::java.util.Date._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setMonth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Date.staticClass, "setMonth", "(I)V", ref global::java.util.Date._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setHours(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Date.staticClass, "setHours", "(I)V", ref global::java.util.Date._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setMinutes(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Date.staticClass, "setMinutes", "(I)V", ref global::java.util.Date._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setSeconds(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Date.staticClass, "setSeconds", "(I)V", ref global::java.util.Date._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setYear(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Date.staticClass, "setYear", "(I)V", ref global::java.util.Date._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Day
		{
			get
			{
				return getDay();
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual int getDay()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, "getDay", "()I", ref global::java.util.Date._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::java.lang.String toLocaleString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Date.staticClass, "toLocaleString", "()Ljava/lang/String;", ref global::java.util.Date._m25) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::java.lang.String toGMTString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Date.staticClass, "toGMTString", "()Ljava/lang/String;", ref global::java.util.Date._m26) as java.lang.String;
		}
		public new int TimezoneOffset
		{
			get
			{
				return getTimezoneOffset();
			}
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual int getTimezoneOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, "getTimezoneOffset", "()I", ref global::java.util.Date._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public Date() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._m28.native == global::System.IntPtr.Zero)
				global::java.util.Date._m28 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._m28);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public Date(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._m29.native == global::System.IntPtr.Zero)
				global::java.util.Date._m29 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public Date(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._m30.native == global::System.IntPtr.Zero)
				global::java.util.Date._m30 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public Date(int arg0, int arg1, int arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._m31.native == global::System.IntPtr.Zero)
				global::java.util.Date._m31 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(IIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public Date(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._m32.native == global::System.IntPtr.Zero)
				global::java.util.Date._m32 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(IIIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public Date(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._m33.native == global::System.IntPtr.Zero)
				global::java.util.Date._m33 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Date()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Date.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Date"));
		}
		internal static void InitJNI()
		{
		}
	}
}
