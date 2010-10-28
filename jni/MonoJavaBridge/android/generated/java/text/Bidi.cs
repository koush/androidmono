namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Bidi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Bidi()
		{
			InitJNI();
		}
		internal Bidi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString25199;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.Bidi._toString25199)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._toString25199)) as java.lang.String;
		}
		public new int Length
		{
			get
			{
				return getLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLength25200;
		public int getLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Bidi._getLength25200);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._getLength25200);
		}
		internal static global::MonoJavaBridge.MethodId _getRunStart25201;
		public int getRunStart(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Bidi._getRunStart25201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._getRunStart25201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRunLimit25202;
		public int getRunLimit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Bidi._getRunLimit25202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._getRunLimit25202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createLineBidi25203;
		public global::java.text.Bidi createLineBidi(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.text.Bidi>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.Bidi._createLineBidi25203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.text.Bidi;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.text.Bidi>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._createLineBidi25203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.text.Bidi;
		}
		internal static global::MonoJavaBridge.MethodId _isMixed25204;
		public bool isMixed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.Bidi._isMixed25204);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._isMixed25204);
		}
		internal static global::MonoJavaBridge.MethodId _isLeftToRight25205;
		public bool isLeftToRight()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.Bidi._isLeftToRight25205);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._isLeftToRight25205);
		}
		internal static global::MonoJavaBridge.MethodId _isRightToLeft25206;
		public bool isRightToLeft()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.Bidi._isRightToLeft25206);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._isRightToLeft25206);
		}
		internal static global::MonoJavaBridge.MethodId _baseIsLeftToRight25207;
		public bool baseIsLeftToRight()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.Bidi._baseIsLeftToRight25207);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._baseIsLeftToRight25207);
		}
		public new int BaseLevel
		{
			get
			{
				return getBaseLevel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseLevel25208;
		public int getBaseLevel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Bidi._getBaseLevel25208);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._getBaseLevel25208);
		}
		internal static global::MonoJavaBridge.MethodId _getLevelAt25209;
		public int getLevelAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Bidi._getLevelAt25209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._getLevelAt25209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int RunCount
		{
			get
			{
				return getRunCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRunCount25210;
		public int getRunCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Bidi._getRunCount25210);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._getRunCount25210);
		}
		internal static global::MonoJavaBridge.MethodId _getRunLevel25211;
		public int getRunLevel(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Bidi._getRunLevel25211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._getRunLevel25211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requiresBidi25212;
		public static bool requiresBidi(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.text.Bidi.staticClass, global::java.text.Bidi._requiresBidi25212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _reorderVisually25213;
		public static void reorderVisually(byte[] arg0, int arg1, java.lang.Object[] arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.text.Bidi.staticClass, global::java.text.Bidi._reorderVisually25213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _Bidi25214;
		public Bidi(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.Bidi.staticClass, global::java.text.Bidi._Bidi25214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Bidi25215;
		public Bidi(java.text.AttributedCharacterIterator arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.Bidi.staticClass, global::java.text.Bidi._Bidi25215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Bidi25216;
		public Bidi(char[] arg0, int arg1, byte[] arg2, int arg3, int arg4, int arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.Bidi.staticClass, global::java.text.Bidi._Bidi25216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		public static int DIRECTION_LEFT_TO_RIGHT
		{
			get
			{
				return 0;
			}
		}
		public static int DIRECTION_RIGHT_TO_LEFT
		{
			get
			{
				return 1;
			}
		}
		public static int DIRECTION_DEFAULT_LEFT_TO_RIGHT
		{
			get
			{
				return -2;
			}
		}
		public static int DIRECTION_DEFAULT_RIGHT_TO_LEFT
		{
			get
			{
				return -1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.Bidi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/Bidi"));
			global::java.text.Bidi._toString25199 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "toString", "()Ljava/lang/String;");
			global::java.text.Bidi._getLength25200 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "getLength", "()I");
			global::java.text.Bidi._getRunStart25201 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "getRunStart", "(I)I");
			global::java.text.Bidi._getRunLimit25202 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "getRunLimit", "(I)I");
			global::java.text.Bidi._createLineBidi25203 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "createLineBidi", "(II)Ljava/text/Bidi;");
			global::java.text.Bidi._isMixed25204 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "isMixed", "()Z");
			global::java.text.Bidi._isLeftToRight25205 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "isLeftToRight", "()Z");
			global::java.text.Bidi._isRightToLeft25206 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "isRightToLeft", "()Z");
			global::java.text.Bidi._baseIsLeftToRight25207 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "baseIsLeftToRight", "()Z");
			global::java.text.Bidi._getBaseLevel25208 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "getBaseLevel", "()I");
			global::java.text.Bidi._getLevelAt25209 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "getLevelAt", "(I)I");
			global::java.text.Bidi._getRunCount25210 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "getRunCount", "()I");
			global::java.text.Bidi._getRunLevel25211 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "getRunLevel", "(I)I");
			global::java.text.Bidi._requiresBidi25212 = @__env.GetStaticMethodIDNoThrow(global::java.text.Bidi.staticClass, "requiresBidi", "([CII)Z");
			global::java.text.Bidi._reorderVisually25213 = @__env.GetStaticMethodIDNoThrow(global::java.text.Bidi.staticClass, "reorderVisually", "([BI[Ljava/lang/Object;II)V");
			global::java.text.Bidi._Bidi25214 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.text.Bidi._Bidi25215 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "<init>", "(Ljava/text/AttributedCharacterIterator;)V");
			global::java.text.Bidi._Bidi25216 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "<init>", "([CI[BIII)V");
		}
	}
}
