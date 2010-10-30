namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Date : java.lang.Object, java.io.Serializable, java.lang.Cloneable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Date(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals26087;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._equals26087.native == global::System.IntPtr.Zero)
				global::java.util.Date._equals26087 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Date.staticClass, global::java.util.Date._equals26087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString26088;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._toString26088.native == global::System.IntPtr.Zero)
				global::java.util.Date._toString26088 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Date.staticClass, global::java.util.Date._toString26088) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26089;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._hashCode26089.native == global::System.IntPtr.Zero)
				global::java.util.Date._hashCode26089 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "hashCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._hashCode26089);
		}
		internal static global::MonoJavaBridge.MethodId _clone26090;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._clone26090.native == global::System.IntPtr.Zero)
				global::java.util.Date._clone26090 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Date.staticClass, global::java.util.Date._clone26090) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo26091;
		public virtual int compareTo(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._compareTo26091.native == global::System.IntPtr.Zero)
				global::java.util.Date._compareTo26091 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "compareTo", "(Ljava/util/Date;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._compareTo26091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo26092;
		public virtual int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._compareTo26092.native == global::System.IntPtr.Zero)
				global::java.util.Date._compareTo26092 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._compareTo26092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _after26093;
		public virtual bool after(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._after26093.native == global::System.IntPtr.Zero)
				global::java.util.Date._after26093 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "after", "(Ljava/util/Date;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Date.staticClass, global::java.util.Date._after26093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _before26094;
		public virtual bool before(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._before26094.native == global::System.IntPtr.Zero)
				global::java.util.Date._before26094 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "before", "(Ljava/util/Date;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Date.staticClass, global::java.util.Date._before26094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse26095;
		public static long parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._parse26095.native == global::System.IntPtr.Zero)
				global::java.util.Date._parse26095 = @__env.GetStaticMethodIDNoThrow(global::java.util.Date.staticClass, "parse", "(Ljava/lang/String;)J");
			return @__env.CallStaticLongMethod(java.util.Date.staticClass, global::java.util.Date._parse26095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTime26096;
		public virtual void setTime(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._setTime26096.native == global::System.IntPtr.Zero)
				global::java.util.Date._setTime26096 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setTime", "(J)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Date.staticClass, global::java.util.Date._setTime26096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTime26097;
		public virtual long getTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._getTime26097.native == global::System.IntPtr.Zero)
				global::java.util.Date._getTime26097 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getTime", "()J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.Date.staticClass, global::java.util.Date._getTime26097);
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
		internal static global::MonoJavaBridge.MethodId _getYear26098;
		public virtual int getYear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._getYear26098.native == global::System.IntPtr.Zero)
				global::java.util.Date._getYear26098 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getYear", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._getYear26098);
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
		internal static global::MonoJavaBridge.MethodId _getMonth26099;
		public virtual int getMonth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._getMonth26099.native == global::System.IntPtr.Zero)
				global::java.util.Date._getMonth26099 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getMonth", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._getMonth26099);
		}
		internal static global::MonoJavaBridge.MethodId _getDate26100;
		public virtual int getDate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._getDate26100.native == global::System.IntPtr.Zero)
				global::java.util.Date._getDate26100 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getDate", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._getDate26100);
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
		internal static global::MonoJavaBridge.MethodId _getHours26101;
		public virtual int getHours()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._getHours26101.native == global::System.IntPtr.Zero)
				global::java.util.Date._getHours26101 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getHours", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._getHours26101);
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
		internal static global::MonoJavaBridge.MethodId _getMinutes26102;
		public virtual int getMinutes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._getMinutes26102.native == global::System.IntPtr.Zero)
				global::java.util.Date._getMinutes26102 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getMinutes", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._getMinutes26102);
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
		internal static global::MonoJavaBridge.MethodId _getSeconds26103;
		public virtual int getSeconds()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._getSeconds26103.native == global::System.IntPtr.Zero)
				global::java.util.Date._getSeconds26103 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getSeconds", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._getSeconds26103);
		}
		internal static global::MonoJavaBridge.MethodId _UTC26104;
		public static long UTC(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._UTC26104.native == global::System.IntPtr.Zero)
				global::java.util.Date._UTC26104 = @__env.GetStaticMethodIDNoThrow(global::java.util.Date.staticClass, "UTC", "(IIIIII)J");
			return @__env.CallStaticLongMethod(java.util.Date.staticClass, global::java.util.Date._UTC26104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _setDate26105;
		public virtual void setDate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._setDate26105.native == global::System.IntPtr.Zero)
				global::java.util.Date._setDate26105 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setDate", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Date.staticClass, global::java.util.Date._setDate26105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMonth26106;
		public virtual void setMonth(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._setMonth26106.native == global::System.IntPtr.Zero)
				global::java.util.Date._setMonth26106 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setMonth", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Date.staticClass, global::java.util.Date._setMonth26106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHours26107;
		public virtual void setHours(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._setHours26107.native == global::System.IntPtr.Zero)
				global::java.util.Date._setHours26107 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setHours", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Date.staticClass, global::java.util.Date._setHours26107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinutes26108;
		public virtual void setMinutes(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._setMinutes26108.native == global::System.IntPtr.Zero)
				global::java.util.Date._setMinutes26108 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setMinutes", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Date.staticClass, global::java.util.Date._setMinutes26108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSeconds26109;
		public virtual void setSeconds(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._setSeconds26109.native == global::System.IntPtr.Zero)
				global::java.util.Date._setSeconds26109 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setSeconds", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Date.staticClass, global::java.util.Date._setSeconds26109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setYear26110;
		public virtual void setYear(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._setYear26110.native == global::System.IntPtr.Zero)
				global::java.util.Date._setYear26110 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setYear", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Date.staticClass, global::java.util.Date._setYear26110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Day
		{
			get
			{
				return getDay();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDay26111;
		public virtual int getDay()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._getDay26111.native == global::System.IntPtr.Zero)
				global::java.util.Date._getDay26111 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getDay", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._getDay26111);
		}
		internal static global::MonoJavaBridge.MethodId _toLocaleString26112;
		public virtual global::java.lang.String toLocaleString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._toLocaleString26112.native == global::System.IntPtr.Zero)
				global::java.util.Date._toLocaleString26112 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "toLocaleString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Date.staticClass, global::java.util.Date._toLocaleString26112) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toGMTString26113;
		public virtual global::java.lang.String toGMTString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._toGMTString26113.native == global::System.IntPtr.Zero)
				global::java.util.Date._toGMTString26113 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "toGMTString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Date.staticClass, global::java.util.Date._toGMTString26113) as java.lang.String;
		}
		public new int TimezoneOffset
		{
			get
			{
				return getTimezoneOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimezoneOffset26114;
		public virtual int getTimezoneOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._getTimezoneOffset26114.native == global::System.IntPtr.Zero)
				global::java.util.Date._getTimezoneOffset26114 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getTimezoneOffset", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._getTimezoneOffset26114);
		}
		internal static global::MonoJavaBridge.MethodId _Date26115;
		public Date() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._Date26115.native == global::System.IntPtr.Zero)
				global::java.util.Date._Date26115 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date26115);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date26116;
		public Date(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._Date26116.native == global::System.IntPtr.Zero)
				global::java.util.Date._Date26116 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date26116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date26117;
		public Date(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._Date26117.native == global::System.IntPtr.Zero)
				global::java.util.Date._Date26117 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date26117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date26118;
		public Date(int arg0, int arg1, int arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._Date26118.native == global::System.IntPtr.Zero)
				global::java.util.Date._Date26118 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(IIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date26118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date26119;
		public Date(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._Date26119.native == global::System.IntPtr.Zero)
				global::java.util.Date._Date26119 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(IIIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date26119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date26120;
		public Date(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Date._Date26120.native == global::System.IntPtr.Zero)
				global::java.util.Date._Date26120 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date26120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
