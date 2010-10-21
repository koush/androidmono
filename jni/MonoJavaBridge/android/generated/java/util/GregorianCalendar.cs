namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GregorianCalendar : java.util.Calendar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GregorianCalendar()
		{
			InitJNI();
		}
		protected GregorianCalendar(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26094;
		public override void add(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._add26094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._add26094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals26095;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.GregorianCalendar._equals26095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._equals26095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26096;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._hashCode26096);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._hashCode26096);
		}
		internal static global::MonoJavaBridge.MethodId _clone26097;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.GregorianCalendar._clone26097)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._clone26097)) as java.lang.Object;
		}
		public new global::java.util.TimeZone TimeZone
		{
			get
			{
				return getTimeZone();
			}
			set
			{
				setTimeZone(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimeZone26098;
		public override global::java.util.TimeZone getTimeZone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.GregorianCalendar._getTimeZone26098)) as java.util.TimeZone;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getTimeZone26098)) as java.util.TimeZone;
		}
		internal static global::MonoJavaBridge.MethodId _setTimeZone26099;
		public override void setTimeZone(java.util.TimeZone arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._setTimeZone26099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._setTimeZone26099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLeapYear26100;
		public virtual bool isLeapYear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.GregorianCalendar._isLeapYear26100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._isLeapYear26100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeTime26101;
		protected override void computeTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._computeTime26101);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._computeTime26101);
		}
		internal static global::MonoJavaBridge.MethodId _computeFields26102;
		protected override void computeFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._computeFields26102);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._computeFields26102);
		}
		internal static global::MonoJavaBridge.MethodId _roll26103;
		public override void roll(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._roll26103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._roll26103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _roll26104;
		public override void roll(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._roll26104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._roll26104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMinimum26105;
		public override int getMinimum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._getMinimum26105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getMinimum26105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaximum26106;
		public override int getMaximum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._getMaximum26106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getMaximum26106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGreatestMinimum26107;
		public override int getGreatestMinimum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._getGreatestMinimum26107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getGreatestMinimum26107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLeastMaximum26108;
		public override int getLeastMaximum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._getLeastMaximum26108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getLeastMaximum26108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getActualMinimum26109;
		public override int getActualMinimum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._getActualMinimum26109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getActualMinimum26109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getActualMaximum26110;
		public override int getActualMaximum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._getActualMaximum26110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getActualMaximum26110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGregorianChange26111;
		public virtual void setGregorianChange(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._setGregorianChange26111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._setGregorianChange26111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Date GregorianChange
		{
			get
			{
				return getGregorianChange();
			}
			set
			{
				setGregorianChange(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGregorianChange26112;
		public virtual global::java.util.Date getGregorianChange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.GregorianCalendar._getGregorianChange26112)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getGregorianChange26112)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26113;
		public GregorianCalendar()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26113);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26114;
		public GregorianCalendar(java.util.TimeZone arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26115;
		public GregorianCalendar(java.util.Locale arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26116;
		public GregorianCalendar(java.util.TimeZone arg0, java.util.Locale arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26117;
		public GregorianCalendar(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26118;
		public GregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26119;
		public GregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		public static int BC
		{
			get
			{
				return 0;
			}
		}
		public static int AD
		{
			get
			{
				return 1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.GregorianCalendar.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/GregorianCalendar"));
			global::java.util.GregorianCalendar._add26094 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "add", "(II)V");
			global::java.util.GregorianCalendar._equals26095 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.GregorianCalendar._hashCode26096 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "hashCode", "()I");
			global::java.util.GregorianCalendar._clone26097 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.GregorianCalendar._getTimeZone26098 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getTimeZone", "()Ljava/util/TimeZone;");
			global::java.util.GregorianCalendar._setTimeZone26099 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "setTimeZone", "(Ljava/util/TimeZone;)V");
			global::java.util.GregorianCalendar._isLeapYear26100 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "isLeapYear", "(I)Z");
			global::java.util.GregorianCalendar._computeTime26101 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "computeTime", "()V");
			global::java.util.GregorianCalendar._computeFields26102 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "computeFields", "()V");
			global::java.util.GregorianCalendar._roll26103 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "roll", "(II)V");
			global::java.util.GregorianCalendar._roll26104 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "roll", "(IZ)V");
			global::java.util.GregorianCalendar._getMinimum26105 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getMinimum", "(I)I");
			global::java.util.GregorianCalendar._getMaximum26106 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getMaximum", "(I)I");
			global::java.util.GregorianCalendar._getGreatestMinimum26107 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getGreatestMinimum", "(I)I");
			global::java.util.GregorianCalendar._getLeastMaximum26108 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getLeastMaximum", "(I)I");
			global::java.util.GregorianCalendar._getActualMinimum26109 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getActualMinimum", "(I)I");
			global::java.util.GregorianCalendar._getActualMaximum26110 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getActualMaximum", "(I)I");
			global::java.util.GregorianCalendar._setGregorianChange26111 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "setGregorianChange", "(Ljava/util/Date;)V");
			global::java.util.GregorianCalendar._getGregorianChange26112 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getGregorianChange", "()Ljava/util/Date;");
			global::java.util.GregorianCalendar._GregorianCalendar26113 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "()V");
			global::java.util.GregorianCalendar._GregorianCalendar26114 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(Ljava/util/TimeZone;)V");
			global::java.util.GregorianCalendar._GregorianCalendar26115 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(Ljava/util/Locale;)V");
			global::java.util.GregorianCalendar._GregorianCalendar26116 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(Ljava/util/TimeZone;Ljava/util/Locale;)V");
			global::java.util.GregorianCalendar._GregorianCalendar26117 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(III)V");
			global::java.util.GregorianCalendar._GregorianCalendar26118 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(IIIII)V");
			global::java.util.GregorianCalendar._GregorianCalendar26119 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(IIIIII)V");
		}
	}
}
