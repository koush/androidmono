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
		internal static global::MonoJavaBridge.MethodId _add26212;
		public override void add(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._add26212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._add26212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals26213;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.GregorianCalendar._equals26213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._equals26213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26214;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._hashCode26214);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._hashCode26214);
		}
		internal static global::MonoJavaBridge.MethodId _clone26215;
		public override global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.GregorianCalendar._clone26215)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._clone26215)) as java.lang.Object;
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
		internal static global::MonoJavaBridge.MethodId _getTimeZone26216;
		public override global::java.util.TimeZone getTimeZone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.GregorianCalendar._getTimeZone26216)) as java.util.TimeZone;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getTimeZone26216)) as java.util.TimeZone;
		}
		internal static global::MonoJavaBridge.MethodId _setTimeZone26217;
		public override void setTimeZone(java.util.TimeZone arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._setTimeZone26217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._setTimeZone26217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLeapYear26218;
		public virtual bool isLeapYear(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.GregorianCalendar._isLeapYear26218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._isLeapYear26218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeTime26219;
		protected override void computeTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._computeTime26219);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._computeTime26219);
		}
		internal static global::MonoJavaBridge.MethodId _computeFields26220;
		protected override void computeFields()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._computeFields26220);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._computeFields26220);
		}
		internal static global::MonoJavaBridge.MethodId _roll26221;
		public override void roll(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._roll26221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._roll26221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _roll26222;
		public override void roll(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._roll26222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._roll26222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMinimum26223;
		public override int getMinimum(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._getMinimum26223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getMinimum26223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaximum26224;
		public override int getMaximum(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._getMaximum26224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getMaximum26224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGreatestMinimum26225;
		public override int getGreatestMinimum(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._getGreatestMinimum26225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getGreatestMinimum26225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLeastMaximum26226;
		public override int getLeastMaximum(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._getLeastMaximum26226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getLeastMaximum26226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getActualMinimum26227;
		public override int getActualMinimum(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._getActualMinimum26227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getActualMinimum26227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getActualMaximum26228;
		public override int getActualMaximum(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.GregorianCalendar._getActualMaximum26228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getActualMaximum26228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGregorianChange26229;
		public virtual void setGregorianChange(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar._setGregorianChange26229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._setGregorianChange26229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getGregorianChange26230;
		public virtual global::java.util.Date getGregorianChange()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.GregorianCalendar._getGregorianChange26230)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._getGregorianChange26230)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26231;
		public GregorianCalendar() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26231);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26232;
		public GregorianCalendar(java.util.TimeZone arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26233;
		public GregorianCalendar(java.util.Locale arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26234;
		public GregorianCalendar(java.util.TimeZone arg0, java.util.Locale arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26235;
		public GregorianCalendar(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26236;
		public GregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26237;
		public GregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
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
			global::java.util.GregorianCalendar._add26212 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "add", "(II)V");
			global::java.util.GregorianCalendar._equals26213 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.GregorianCalendar._hashCode26214 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "hashCode", "()I");
			global::java.util.GregorianCalendar._clone26215 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.GregorianCalendar._getTimeZone26216 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getTimeZone", "()Ljava/util/TimeZone;");
			global::java.util.GregorianCalendar._setTimeZone26217 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "setTimeZone", "(Ljava/util/TimeZone;)V");
			global::java.util.GregorianCalendar._isLeapYear26218 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "isLeapYear", "(I)Z");
			global::java.util.GregorianCalendar._computeTime26219 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "computeTime", "()V");
			global::java.util.GregorianCalendar._computeFields26220 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "computeFields", "()V");
			global::java.util.GregorianCalendar._roll26221 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "roll", "(II)V");
			global::java.util.GregorianCalendar._roll26222 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "roll", "(IZ)V");
			global::java.util.GregorianCalendar._getMinimum26223 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getMinimum", "(I)I");
			global::java.util.GregorianCalendar._getMaximum26224 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getMaximum", "(I)I");
			global::java.util.GregorianCalendar._getGreatestMinimum26225 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getGreatestMinimum", "(I)I");
			global::java.util.GregorianCalendar._getLeastMaximum26226 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getLeastMaximum", "(I)I");
			global::java.util.GregorianCalendar._getActualMinimum26227 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getActualMinimum", "(I)I");
			global::java.util.GregorianCalendar._getActualMaximum26228 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getActualMaximum", "(I)I");
			global::java.util.GregorianCalendar._setGregorianChange26229 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "setGregorianChange", "(Ljava/util/Date;)V");
			global::java.util.GregorianCalendar._getGregorianChange26230 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "getGregorianChange", "()Ljava/util/Date;");
			global::java.util.GregorianCalendar._GregorianCalendar26231 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "()V");
			global::java.util.GregorianCalendar._GregorianCalendar26232 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(Ljava/util/TimeZone;)V");
			global::java.util.GregorianCalendar._GregorianCalendar26233 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(Ljava/util/Locale;)V");
			global::java.util.GregorianCalendar._GregorianCalendar26234 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(Ljava/util/TimeZone;Ljava/util/Locale;)V");
			global::java.util.GregorianCalendar._GregorianCalendar26235 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(III)V");
			global::java.util.GregorianCalendar._GregorianCalendar26236 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(IIIII)V");
			global::java.util.GregorianCalendar._GregorianCalendar26237 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(IIIIII)V");
		}
	}
}
