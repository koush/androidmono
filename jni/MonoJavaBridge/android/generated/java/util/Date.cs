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
		internal static global::MonoJavaBridge.MethodId _equals20148;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Date._equals20148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._equals20148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20149;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Date._toString20149)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._toString20149)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20150;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._hashCode20150);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._hashCode20150);
		}
		internal static global::MonoJavaBridge.MethodId _clone20151;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Date._clone20151)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._clone20151)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20152;
		public virtual int compareTo(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._compareTo20152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._compareTo20152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20153;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._compareTo20153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._compareTo20153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _after20154;
		public virtual bool after(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Date._after20154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._after20154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _before20155;
		public virtual bool before(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Date._before20155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._before20155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse20156;
		public static long parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.util.Date.staticClass, global::java.util.Date._parse20156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTime20157;
		public virtual void setTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setTime20157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setTime20157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTime20158;
		public virtual long getTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.Date._getTime20158);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getTime20158);
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
		internal static global::MonoJavaBridge.MethodId _getYear20159;
		public virtual int getYear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getYear20159);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getYear20159);
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
		internal static global::MonoJavaBridge.MethodId _getMonth20160;
		public virtual int getMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getMonth20160);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getMonth20160);
		}
		internal static global::MonoJavaBridge.MethodId _getDate20161;
		public virtual int getDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getDate20161);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getDate20161);
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
		internal static global::MonoJavaBridge.MethodId _getHours20162;
		public virtual int getHours() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getHours20162);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getHours20162);
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
		internal static global::MonoJavaBridge.MethodId _getMinutes20163;
		public virtual int getMinutes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getMinutes20163);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getMinutes20163);
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
		internal static global::MonoJavaBridge.MethodId _getSeconds20164;
		public virtual int getSeconds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getSeconds20164);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getSeconds20164);
		}
		internal static global::MonoJavaBridge.MethodId _UTC20165;
		public static long UTC(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.util.Date.staticClass, global::java.util.Date._UTC20165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _setDate20166;
		public virtual void setDate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setDate20166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setDate20166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMonth20167;
		public virtual void setMonth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setMonth20167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setMonth20167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHours20168;
		public virtual void setHours(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setHours20168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setHours20168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinutes20169;
		public virtual void setMinutes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setMinutes20169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setMinutes20169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSeconds20170;
		public virtual void setSeconds(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setSeconds20170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setSeconds20170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setYear20171;
		public virtual void setYear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Date._setYear20171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._setYear20171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Day
		{
			get
			{
				return getDay();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDay20172;
		public virtual int getDay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getDay20172);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getDay20172);
		}
		internal static global::MonoJavaBridge.MethodId _toLocaleString20173;
		public virtual global::java.lang.String toLocaleString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Date._toLocaleString20173)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._toLocaleString20173)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toGMTString20174;
		public virtual global::java.lang.String toGMTString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Date._toGMTString20174)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._toGMTString20174)) as java.lang.String;
		}
		public new int TimezoneOffset
		{
			get
			{
				return getTimezoneOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimezoneOffset20175;
		public virtual int getTimezoneOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Date._getTimezoneOffset20175);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Date.staticClass, global::java.util.Date._getTimezoneOffset20175);
		}
		internal static global::MonoJavaBridge.MethodId _Date20176;
		public Date()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date20176);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date20177;
		public Date(long arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date20177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date20178;
		public Date(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date20178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date20179;
		public Date(int arg0, int arg1, int arg2, int arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date20179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date20180;
		public Date(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date20180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Date20181;
		public Date(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date20181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Date.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Date"));
			global::java.util.Date._equals20148 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Date._toString20149 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Date._hashCode20150 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "hashCode", "()I");
			global::java.util.Date._clone20151 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Date._compareTo20152 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "compareTo", "(Ljava/util/Date;)I");
			global::java.util.Date._compareTo20153 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.util.Date._after20154 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "after", "(Ljava/util/Date;)Z");
			global::java.util.Date._before20155 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "before", "(Ljava/util/Date;)Z");
			global::java.util.Date._parse20156 = @__env.GetStaticMethodIDNoThrow(global::java.util.Date.staticClass, "parse", "(Ljava/lang/String;)J");
			global::java.util.Date._setTime20157 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setTime", "(J)V");
			global::java.util.Date._getTime20158 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getTime", "()J");
			global::java.util.Date._getYear20159 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getYear", "()I");
			global::java.util.Date._getMonth20160 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getMonth", "()I");
			global::java.util.Date._getDate20161 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getDate", "()I");
			global::java.util.Date._getHours20162 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getHours", "()I");
			global::java.util.Date._getMinutes20163 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getMinutes", "()I");
			global::java.util.Date._getSeconds20164 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getSeconds", "()I");
			global::java.util.Date._UTC20165 = @__env.GetStaticMethodIDNoThrow(global::java.util.Date.staticClass, "UTC", "(IIIIII)J");
			global::java.util.Date._setDate20166 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setDate", "(I)V");
			global::java.util.Date._setMonth20167 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setMonth", "(I)V");
			global::java.util.Date._setHours20168 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setHours", "(I)V");
			global::java.util.Date._setMinutes20169 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setMinutes", "(I)V");
			global::java.util.Date._setSeconds20170 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setSeconds", "(I)V");
			global::java.util.Date._setYear20171 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "setYear", "(I)V");
			global::java.util.Date._getDay20172 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getDay", "()I");
			global::java.util.Date._toLocaleString20173 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "toLocaleString", "()Ljava/lang/String;");
			global::java.util.Date._toGMTString20174 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "toGMTString", "()Ljava/lang/String;");
			global::java.util.Date._getTimezoneOffset20175 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "getTimezoneOffset", "()I");
			global::java.util.Date._Date20176 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "()V");
			global::java.util.Date._Date20177 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(J)V");
			global::java.util.Date._Date20178 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(III)V");
			global::java.util.Date._Date20179 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(IIIII)V");
			global::java.util.Date._Date20180 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(IIIIII)V");
			global::java.util.Date._Date20181 = @__env.GetMethodIDNoThrow(global::java.util.Date.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
