namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Date : java.lang.Object, java.io.Serializable, java.lang.Cloneable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Date()
		{
			InitJNI();
		}
		protected Date(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals26086;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Date._equals26086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._equals26086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString26087;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Date._toString26087)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._toString26087)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26088;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._hashCode26088);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._hashCode26088);
		}
		internal static global::MonoJavaBridge.MethodId _clone26089;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Date._clone26089)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._clone26089)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo26090;
		public virtual int compareTo(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._compareTo26090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._compareTo26090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo26091;
		public virtual int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._compareTo26091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._compareTo26091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _after26092;
		public virtual bool after(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Date._after26092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._after26092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _before26093;
		public virtual bool before(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Date._before26093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._before26093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse26094;
		public static long parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.util.Date.staticClass, global::java.util.Date._parse26094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTime26095;
		public virtual void setTime(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setTime26095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setTime26095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTime26096;
		public virtual long getTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.Date._getTime26096);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getTime26096);
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
		internal static global::MonoJavaBridge.MethodId _getYear26097;
		public virtual int getYear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getYear26097);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getYear26097);
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
		internal static global::MonoJavaBridge.MethodId _getMonth26098;
		public virtual int getMonth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getMonth26098);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getMonth26098);
		}
		internal static global::MonoJavaBridge.MethodId _getDate26099;
		public virtual int getDate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getDate26099);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getDate26099);
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
		internal static global::MonoJavaBridge.MethodId _getHours26100;
		public virtual int getHours()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getHours26100);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getHours26100);
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
		internal static global::MonoJavaBridge.MethodId _getMinutes26101;
		public virtual int getMinutes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getMinutes26101);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getMinutes26101);
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
		internal static global::MonoJavaBridge.MethodId _getSeconds26102;
		public virtual int getSeconds()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getSeconds26102);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getSeconds26102);
		}
		internal static global::MonoJavaBridge.MethodId _UTC26103;
		public static long UTC(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.util.Date.staticClass, global::java.util.Date._UTC26103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _setDate26104;
		public virtual void setDate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setDate26104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setDate26104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMonth26105;
		public virtual void setMonth(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setMonth26105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setMonth26105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHours26106;
		public virtual void setHours(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setHours26106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setHours26106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinutes26107;
		public virtual void setMinutes(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setMinutes26107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setMinutes26107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSeconds26108;
		public virtual void setSeconds(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setSeconds26108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setSeconds26108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setYear26109;
		public virtual void setYear(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setYear26109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setYear26109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Day
		{
			get
			{
				return getDay();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDay26110;
		public virtual int getDay()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getDay26110);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getDay26110);
		}
		internal static global::MonoJavaBridge.MethodId _toLocaleString26111;
		public virtual global::java.lang.String toLocaleString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Date._toLocaleString26111)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._toLocaleString26111)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toGMTString26112;
		public virtual global::java.lang.String toGMTString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Date._toGMTString26112)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._toGMTString26112)) as java.lang.String;
		}
		public new int TimezoneOffset
		{
			get
			{
				return getTimezoneOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimezoneOffset26113;
		public virtual int getTimezoneOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getTimezoneOffset26113);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getTimezoneOffset26113);
		}
		internal static global::MonoJavaBridge.MethodId _Date26114;
		public Date() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date26114);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date26115;
		public Date(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date26115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date26116;
		public Date(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date26116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date26117;
		public Date(int arg0, int arg1, int arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date26117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date26118;
		public Date(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date26118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date26119;
		public Date(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date26119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Date.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Date"));
			global::java.util.Date._equals26086 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Date._toString26087 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Date._hashCode26088 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "hashCode", "()I");
			global::java.util.Date._clone26089 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Date._compareTo26090 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "compareTo", "(Ljava/util/Date;)I");
			global::java.util.Date._compareTo26091 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.util.Date._after26092 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "after", "(Ljava/util/Date;)Z");
			global::java.util.Date._before26093 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "before", "(Ljava/util/Date;)Z");
			global::java.util.Date._parse26094 = @__env.GetStaticMethodIDNoThrow(global::java.util.Date.staticClass, "parse", "(Ljava/lang/String;)J");
			global::java.util.Date._setTime26095 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setTime", "(J)V");
			global::java.util.Date._getTime26096 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getTime", "()J");
			global::java.util.Date._getYear26097 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getYear", "()I");
			global::java.util.Date._getMonth26098 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getMonth", "()I");
			global::java.util.Date._getDate26099 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getDate", "()I");
			global::java.util.Date._getHours26100 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getHours", "()I");
			global::java.util.Date._getMinutes26101 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getMinutes", "()I");
			global::java.util.Date._getSeconds26102 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getSeconds", "()I");
			global::java.util.Date._UTC26103 = @__env.GetStaticMethodIDNoThrow(global::java.util.Date.staticClass, "UTC", "(IIIIII)J");
			global::java.util.Date._setDate26104 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setDate", "(I)V");
			global::java.util.Date._setMonth26105 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setMonth", "(I)V");
			global::java.util.Date._setHours26106 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setHours", "(I)V");
			global::java.util.Date._setMinutes26107 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setMinutes", "(I)V");
			global::java.util.Date._setSeconds26108 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setSeconds", "(I)V");
			global::java.util.Date._setYear26109 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setYear", "(I)V");
			global::java.util.Date._getDay26110 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getDay", "()I");
			global::java.util.Date._toLocaleString26111 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "toLocaleString", "()Ljava/lang/String;");
			global::java.util.Date._toGMTString26112 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "toGMTString", "()Ljava/lang/String;");
			global::java.util.Date._getTimezoneOffset26113 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getTimezoneOffset", "()I");
			global::java.util.Date._Date26114 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "()V");
			global::java.util.Date._Date26115 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(J)V");
			global::java.util.Date._Date26116 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(III)V");
			global::java.util.Date._Date26117 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(IIIII)V");
			global::java.util.Date._Date26118 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(IIIIII)V");
			global::java.util.Date._Date26119 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
