namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SimpleTimeZone : java.util.TimeZone
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SimpleTimeZone()
		{
			InitJNI();
		}
		protected SimpleTimeZone(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals20788;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SimpleTimeZone._equals20788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._equals20788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20789;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SimpleTimeZone._toString20789)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._toString20789)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20790;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SimpleTimeZone._hashCode20790);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._hashCode20790);
		}
		internal static global::MonoJavaBridge.MethodId _clone20791;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SimpleTimeZone._clone20791)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._clone20791)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getOffset20792;
		public override int getOffset(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SimpleTimeZone._getOffset20792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._getOffset20792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOffset20793;
		public override int getOffset(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SimpleTimeZone._getOffset20793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._getOffset20793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		public new int RawOffset
		{
			get
			{
				return getRawOffset();
			}
			set
			{
				setRawOffset(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawOffset20794;
		public override int getRawOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SimpleTimeZone._getRawOffset20794);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._getRawOffset20794);
		}
		internal static global::MonoJavaBridge.MethodId _hasSameRules20795;
		public override bool hasSameRules(java.util.TimeZone arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SimpleTimeZone._hasSameRules20795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._hasSameRules20795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRawOffset20796;
		public override void setRawOffset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SimpleTimeZone._setRawOffset20796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._setRawOffset20796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DSTSavings
		{
			get
			{
				return getDSTSavings();
			}
			set
			{
				setDSTSavings(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDSTSavings20797;
		public override int getDSTSavings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SimpleTimeZone._getDSTSavings20797);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._getDSTSavings20797);
		}
		internal static global::MonoJavaBridge.MethodId _useDaylightTime20798;
		public override bool useDaylightTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SimpleTimeZone._useDaylightTime20798);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._useDaylightTime20798);
		}
		internal static global::MonoJavaBridge.MethodId _inDaylightTime20799;
		public override bool inDaylightTime(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SimpleTimeZone._inDaylightTime20799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._inDaylightTime20799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStartYear20800;
		public virtual void setStartYear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SimpleTimeZone._setStartYear20800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._setStartYear20800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStartRule20801;
		public virtual void setStartRule(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SimpleTimeZone._setStartRule20801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._setStartRule20801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setStartRule20802;
		public virtual void setStartRule(int arg0, int arg1, int arg2, int arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SimpleTimeZone._setStartRule20802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._setStartRule20802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _setStartRule20803;
		public virtual void setStartRule(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SimpleTimeZone._setStartRule20803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._setStartRule20803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setEndRule20804;
		public virtual void setEndRule(int arg0, int arg1, int arg2, int arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SimpleTimeZone._setEndRule20804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._setEndRule20804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _setEndRule20805;
		public virtual void setEndRule(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SimpleTimeZone._setEndRule20805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._setEndRule20805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setEndRule20806;
		public virtual void setEndRule(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SimpleTimeZone._setEndRule20806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._setEndRule20806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setDSTSavings20807;
		public virtual void setDSTSavings(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SimpleTimeZone._setDSTSavings20807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._setDSTSavings20807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SimpleTimeZone20808;
		public SimpleTimeZone(int arg0, java.lang.String arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._SimpleTimeZone20808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleTimeZone20809;
		public SimpleTimeZone(int arg0, java.lang.String arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._SimpleTimeZone20809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleTimeZone20810;
		public SimpleTimeZone(int arg0, java.lang.String arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10, int arg11, int arg12)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._SimpleTimeZone20810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg12));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleTimeZone20811;
		public SimpleTimeZone(int arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._SimpleTimeZone20811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int WALL_TIME
		{
			get
			{
				return 0;
			}
		}
		public static int STANDARD_TIME
		{
			get
			{
				return 1;
			}
		}
		public static int UTC_TIME
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.SimpleTimeZone.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/SimpleTimeZone"));
			global::java.util.SimpleTimeZone._equals20788 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.SimpleTimeZone._toString20789 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.SimpleTimeZone._hashCode20790 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "hashCode", "()I");
			global::java.util.SimpleTimeZone._clone20791 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.SimpleTimeZone._getOffset20792 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "getOffset", "(J)I");
			global::java.util.SimpleTimeZone._getOffset20793 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "getOffset", "(IIIIII)I");
			global::java.util.SimpleTimeZone._getRawOffset20794 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "getRawOffset", "()I");
			global::java.util.SimpleTimeZone._hasSameRules20795 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "hasSameRules", "(Ljava/util/TimeZone;)Z");
			global::java.util.SimpleTimeZone._setRawOffset20796 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "setRawOffset", "(I)V");
			global::java.util.SimpleTimeZone._getDSTSavings20797 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "getDSTSavings", "()I");
			global::java.util.SimpleTimeZone._useDaylightTime20798 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "useDaylightTime", "()Z");
			global::java.util.SimpleTimeZone._inDaylightTime20799 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "inDaylightTime", "(Ljava/util/Date;)Z");
			global::java.util.SimpleTimeZone._setStartYear20800 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "setStartYear", "(I)V");
			global::java.util.SimpleTimeZone._setStartRule20801 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "setStartRule", "(III)V");
			global::java.util.SimpleTimeZone._setStartRule20802 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "setStartRule", "(IIIIZ)V");
			global::java.util.SimpleTimeZone._setStartRule20803 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "setStartRule", "(IIII)V");
			global::java.util.SimpleTimeZone._setEndRule20804 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "setEndRule", "(IIIIZ)V");
			global::java.util.SimpleTimeZone._setEndRule20805 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "setEndRule", "(III)V");
			global::java.util.SimpleTimeZone._setEndRule20806 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "setEndRule", "(IIII)V");
			global::java.util.SimpleTimeZone._setDSTSavings20807 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "setDSTSavings", "(I)V");
			global::java.util.SimpleTimeZone._SimpleTimeZone20808 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "<init>", "(ILjava/lang/String;IIIIIIII)V");
			global::java.util.SimpleTimeZone._SimpleTimeZone20809 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "<init>", "(ILjava/lang/String;IIIIIIIII)V");
			global::java.util.SimpleTimeZone._SimpleTimeZone20810 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "<init>", "(ILjava/lang/String;IIIIIIIIIII)V");
			global::java.util.SimpleTimeZone._SimpleTimeZone20811 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "<init>", "(ILjava/lang/String;)V");
		}
	}
}
