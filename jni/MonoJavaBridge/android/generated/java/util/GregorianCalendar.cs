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
		internal static global::MonoJavaBridge.MethodId _add20271;
		public override void add(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._add20271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._add20271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals20272;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.GregorianCalendar._equals20272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._equals20272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20273;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._hashCode20273);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._hashCode20273);
		}
		internal static global::MonoJavaBridge.MethodId _clone20274;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.GregorianCalendar._clone20274)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._clone20274)) as java.lang.Object;
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
		internal static global::MonoJavaBridge.MethodId _getTimeZone20275;
		public override global::java.util.TimeZone getTimeZone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.GregorianCalendar._getTimeZone20275)) as java.util.TimeZone;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getTimeZone20275)) as java.util.TimeZone;
		}
		internal static global::MonoJavaBridge.MethodId _setTimeZone20276;
		public override void setTimeZone(java.util.TimeZone arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._setTimeZone20276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._setTimeZone20276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLeapYear20277;
		public virtual bool isLeapYear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.GregorianCalendar._isLeapYear20277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._isLeapYear20277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeTime20278;
		protected override void computeTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._computeTime20278);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._computeTime20278);
		}
		internal static global::MonoJavaBridge.MethodId _computeFields20279;
		protected override void computeFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._computeFields20279);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._computeFields20279);
		}
		internal static global::MonoJavaBridge.MethodId _roll20280;
		public override void roll(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._roll20280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._roll20280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _roll20281;
		public override void roll(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._roll20281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._roll20281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMinimum20282;
		public override int getMinimum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._getMinimum20282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getMinimum20282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaximum20283;
		public override int getMaximum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._getMaximum20283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getMaximum20283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGreatestMinimum20284;
		public override int getGreatestMinimum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._getGreatestMinimum20284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getGreatestMinimum20284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLeastMaximum20285;
		public override int getLeastMaximum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._getLeastMaximum20285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getLeastMaximum20285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getActualMinimum20286;
		public override int getActualMinimum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._getActualMinimum20286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getActualMinimum20286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getActualMaximum20287;
		public override int getActualMaximum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._getActualMaximum20287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getActualMaximum20287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGregorianChange20288;
		public virtual void setGregorianChange(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._setGregorianChange20288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._setGregorianChange20288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getGregorianChange20289;
		public virtual global::java.util.Date getGregorianChange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.GregorianCalendar._getGregorianChange20289)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getGregorianChange20289)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar20290;
		public GregorianCalendar()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar20290);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar20291;
		public GregorianCalendar(java.util.TimeZone arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar20291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar20292;
		public GregorianCalendar(java.util.Locale arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar20292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar20293;
		public GregorianCalendar(java.util.TimeZone arg0, java.util.Locale arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar20293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar20294;
		public GregorianCalendar(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar20294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar20295;
		public GregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar20295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar20296;
		public GregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar20296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
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
			global::java.util.GregorianCalendar._add20271 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "add", "(II)V");
			global::java.util.GregorianCalendar._equals20272 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.GregorianCalendar._hashCode20273 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "hashCode", "()I");
			global::java.util.GregorianCalendar._clone20274 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.GregorianCalendar._getTimeZone20275 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getTimeZone", "()Ljava/util/TimeZone;");
			global::java.util.GregorianCalendar._setTimeZone20276 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "setTimeZone", "(Ljava/util/TimeZone;)V");
			global::java.util.GregorianCalendar._isLeapYear20277 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "isLeapYear", "(I)Z");
			global::java.util.GregorianCalendar._computeTime20278 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "computeTime", "()V");
			global::java.util.GregorianCalendar._computeFields20279 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "computeFields", "()V");
			global::java.util.GregorianCalendar._roll20280 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "roll", "(II)V");
			global::java.util.GregorianCalendar._roll20281 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "roll", "(IZ)V");
			global::java.util.GregorianCalendar._getMinimum20282 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getMinimum", "(I)I");
			global::java.util.GregorianCalendar._getMaximum20283 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getMaximum", "(I)I");
			global::java.util.GregorianCalendar._getGreatestMinimum20284 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getGreatestMinimum", "(I)I");
			global::java.util.GregorianCalendar._getLeastMaximum20285 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getLeastMaximum", "(I)I");
			global::java.util.GregorianCalendar._getActualMinimum20286 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getActualMinimum", "(I)I");
			global::java.util.GregorianCalendar._getActualMaximum20287 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getActualMaximum", "(I)I");
			global::java.util.GregorianCalendar._setGregorianChange20288 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "setGregorianChange", "(Ljava/util/Date;)V");
			global::java.util.GregorianCalendar._getGregorianChange20289 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getGregorianChange", "()Ljava/util/Date;");
			global::java.util.GregorianCalendar._GregorianCalendar20290 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "()V");
			global::java.util.GregorianCalendar._GregorianCalendar20291 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(Ljava/util/TimeZone;)V");
			global::java.util.GregorianCalendar._GregorianCalendar20292 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(Ljava/util/Locale;)V");
			global::java.util.GregorianCalendar._GregorianCalendar20293 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(Ljava/util/TimeZone;Ljava/util/Locale;)V");
			global::java.util.GregorianCalendar._GregorianCalendar20294 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(III)V");
			global::java.util.GregorianCalendar._GregorianCalendar20295 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(IIIII)V");
			global::java.util.GregorianCalendar._GregorianCalendar20296 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(IIIIII)V");
		}
	}
}
