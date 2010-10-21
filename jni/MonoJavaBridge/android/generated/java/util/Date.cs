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
		internal static global::MonoJavaBridge.MethodId _equals25968;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Date._equals25968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._equals25968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25969;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Date._toString25969)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._toString25969)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25970;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._hashCode25970);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._hashCode25970);
		}
		internal static global::MonoJavaBridge.MethodId _clone25971;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Date._clone25971)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._clone25971)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo25972;
		public virtual int compareTo(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._compareTo25972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._compareTo25972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo25973;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._compareTo25973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._compareTo25973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _after25974;
		public virtual bool after(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Date._after25974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._after25974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _before25975;
		public virtual bool before(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Date._before25975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._before25975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse25976;
		public static long parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.util.Date.staticClass, global::java.util.Date._parse25976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTime25977;
		public virtual void setTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setTime25977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setTime25977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTime25978;
		public virtual long getTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.Date._getTime25978);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getTime25978);
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
		internal static global::MonoJavaBridge.MethodId _getYear25979;
		public virtual int getYear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getYear25979);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getYear25979);
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
		internal static global::MonoJavaBridge.MethodId _getMonth25980;
		public virtual int getMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getMonth25980);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getMonth25980);
		}
		internal static global::MonoJavaBridge.MethodId _getDate25981;
		public virtual int getDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getDate25981);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getDate25981);
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
		internal static global::MonoJavaBridge.MethodId _getHours25982;
		public virtual int getHours() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getHours25982);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getHours25982);
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
		internal static global::MonoJavaBridge.MethodId _getMinutes25983;
		public virtual int getMinutes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getMinutes25983);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getMinutes25983);
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
		internal static global::MonoJavaBridge.MethodId _getSeconds25984;
		public virtual int getSeconds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getSeconds25984);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getSeconds25984);
		}
		internal static global::MonoJavaBridge.MethodId _UTC25985;
		public static long UTC(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.util.Date.staticClass, global::java.util.Date._UTC25985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _setDate25986;
		public virtual void setDate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setDate25986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setDate25986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMonth25987;
		public virtual void setMonth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setMonth25987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setMonth25987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHours25988;
		public virtual void setHours(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setHours25988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setHours25988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinutes25989;
		public virtual void setMinutes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setMinutes25989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setMinutes25989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSeconds25990;
		public virtual void setSeconds(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setSeconds25990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setSeconds25990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setYear25991;
		public virtual void setYear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setYear25991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setYear25991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Day
		{
			get
			{
				return getDay();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDay25992;
		public virtual int getDay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getDay25992);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getDay25992);
		}
		internal static global::MonoJavaBridge.MethodId _toLocaleString25993;
		public virtual global::java.lang.String toLocaleString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Date._toLocaleString25993)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._toLocaleString25993)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toGMTString25994;
		public virtual global::java.lang.String toGMTString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Date._toGMTString25994)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._toGMTString25994)) as java.lang.String;
		}
		public new int TimezoneOffset
		{
			get
			{
				return getTimezoneOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimezoneOffset25995;
		public virtual int getTimezoneOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getTimezoneOffset25995);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getTimezoneOffset25995);
		}
		internal static global::MonoJavaBridge.MethodId _Date25996;
		public Date()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date25996);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date25997;
		public Date(long arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date25997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date25998;
		public Date(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date25998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date25999;
		public Date(int arg0, int arg1, int arg2, int arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date25999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date26000;
		public Date(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date26000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date26001;
		public Date(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date26001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Date.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Date"));
			global::java.util.Date._equals25968 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Date._toString25969 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Date._hashCode25970 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "hashCode", "()I");
			global::java.util.Date._clone25971 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Date._compareTo25972 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "compareTo", "(Ljava/util/Date;)I");
			global::java.util.Date._compareTo25973 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.util.Date._after25974 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "after", "(Ljava/util/Date;)Z");
			global::java.util.Date._before25975 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "before", "(Ljava/util/Date;)Z");
			global::java.util.Date._parse25976 = @__env.GetStaticMethodIDNoThrow(global::java.util.Date.staticClass, "parse", "(Ljava/lang/String;)J");
			global::java.util.Date._setTime25977 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setTime", "(J)V");
			global::java.util.Date._getTime25978 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getTime", "()J");
			global::java.util.Date._getYear25979 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getYear", "()I");
			global::java.util.Date._getMonth25980 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getMonth", "()I");
			global::java.util.Date._getDate25981 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getDate", "()I");
			global::java.util.Date._getHours25982 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getHours", "()I");
			global::java.util.Date._getMinutes25983 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getMinutes", "()I");
			global::java.util.Date._getSeconds25984 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getSeconds", "()I");
			global::java.util.Date._UTC25985 = @__env.GetStaticMethodIDNoThrow(global::java.util.Date.staticClass, "UTC", "(IIIIII)J");
			global::java.util.Date._setDate25986 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setDate", "(I)V");
			global::java.util.Date._setMonth25987 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setMonth", "(I)V");
			global::java.util.Date._setHours25988 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setHours", "(I)V");
			global::java.util.Date._setMinutes25989 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setMinutes", "(I)V");
			global::java.util.Date._setSeconds25990 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setSeconds", "(I)V");
			global::java.util.Date._setYear25991 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setYear", "(I)V");
			global::java.util.Date._getDay25992 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getDay", "()I");
			global::java.util.Date._toLocaleString25993 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "toLocaleString", "()Ljava/lang/String;");
			global::java.util.Date._toGMTString25994 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "toGMTString", "()Ljava/lang/String;");
			global::java.util.Date._getTimezoneOffset25995 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getTimezoneOffset", "()I");
			global::java.util.Date._Date25996 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "()V");
			global::java.util.Date._Date25997 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(J)V");
			global::java.util.Date._Date25998 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(III)V");
			global::java.util.Date._Date25999 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(IIIII)V");
			global::java.util.Date._Date26000 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(IIIIII)V");
			global::java.util.Date._Date26001 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
