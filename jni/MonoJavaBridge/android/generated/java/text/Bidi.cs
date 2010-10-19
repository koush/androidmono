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
		internal static global::MonoJavaBridge.MethodId _toString19342;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.Bidi._toString19342)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._toString19342)) as java.lang.String;
		}
		public new int Length
		{
			get
			{
				return getLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLength19343;
		public int getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Bidi._getLength19343);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._getLength19343);
		}
		internal static global::MonoJavaBridge.MethodId _getRunStart19344;
		public int getRunStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Bidi._getRunStart19344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._getRunStart19344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRunLimit19345;
		public int getRunLimit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Bidi._getRunLimit19345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._getRunLimit19345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createLineBidi19346;
		public global::java.text.Bidi createLineBidi(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.Bidi._createLineBidi19346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.text.Bidi;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._createLineBidi19346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.text.Bidi;
		}
		internal static global::MonoJavaBridge.MethodId _isMixed19347;
		public bool isMixed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.Bidi._isMixed19347);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._isMixed19347);
		}
		internal static global::MonoJavaBridge.MethodId _isLeftToRight19348;
		public bool isLeftToRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.Bidi._isLeftToRight19348);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._isLeftToRight19348);
		}
		internal static global::MonoJavaBridge.MethodId _isRightToLeft19349;
		public bool isRightToLeft() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.Bidi._isRightToLeft19349);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._isRightToLeft19349);
		}
		internal static global::MonoJavaBridge.MethodId _baseIsLeftToRight19350;
		public bool baseIsLeftToRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.Bidi._baseIsLeftToRight19350);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._baseIsLeftToRight19350);
		}
		public new int BaseLevel
		{
			get
			{
				return getBaseLevel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseLevel19351;
		public int getBaseLevel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Bidi._getBaseLevel19351);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._getBaseLevel19351);
		}
		internal static global::MonoJavaBridge.MethodId _getLevelAt19352;
		public int getLevelAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Bidi._getLevelAt19352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._getLevelAt19352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int RunCount
		{
			get
			{
				return getRunCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRunCount19353;
		public int getRunCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Bidi._getRunCount19353);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._getRunCount19353);
		}
		internal static global::MonoJavaBridge.MethodId _getRunLevel19354;
		public int getRunLevel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Bidi._getRunLevel19354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Bidi.staticClass, global::java.text.Bidi._getRunLevel19354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requiresBidi19355;
		public static bool requiresBidi(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.text.Bidi.staticClass, global::java.text.Bidi._requiresBidi19355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _reorderVisually19356;
		public static void reorderVisually(byte[] arg0, int arg1, java.lang.Object[] arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.text.Bidi.staticClass, global::java.text.Bidi._reorderVisually19356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _Bidi19357;
		public Bidi(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.Bidi.staticClass, global::java.text.Bidi._Bidi19357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Bidi19358;
		public Bidi(java.text.AttributedCharacterIterator arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.Bidi.staticClass, global::java.text.Bidi._Bidi19358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Bidi19359;
		public Bidi(char[] arg0, int arg1, byte[] arg2, int arg3, int arg4, int arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.Bidi.staticClass, global::java.text.Bidi._Bidi19359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
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
			global::java.text.Bidi._toString19342 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "toString", "()Ljava/lang/String;");
			global::java.text.Bidi._getLength19343 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "getLength", "()I");
			global::java.text.Bidi._getRunStart19344 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "getRunStart", "(I)I");
			global::java.text.Bidi._getRunLimit19345 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "getRunLimit", "(I)I");
			global::java.text.Bidi._createLineBidi19346 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "createLineBidi", "(II)Ljava/text/Bidi;");
			global::java.text.Bidi._isMixed19347 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "isMixed", "()Z");
			global::java.text.Bidi._isLeftToRight19348 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "isLeftToRight", "()Z");
			global::java.text.Bidi._isRightToLeft19349 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "isRightToLeft", "()Z");
			global::java.text.Bidi._baseIsLeftToRight19350 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "baseIsLeftToRight", "()Z");
			global::java.text.Bidi._getBaseLevel19351 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "getBaseLevel", "()I");
			global::java.text.Bidi._getLevelAt19352 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "getLevelAt", "(I)I");
			global::java.text.Bidi._getRunCount19353 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "getRunCount", "()I");
			global::java.text.Bidi._getRunLevel19354 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "getRunLevel", "(I)I");
			global::java.text.Bidi._requiresBidi19355 = @__env.GetStaticMethodIDNoThrow(global::java.text.Bidi.staticClass, "requiresBidi", "([CII)Z");
			global::java.text.Bidi._reorderVisually19356 = @__env.GetStaticMethodIDNoThrow(global::java.text.Bidi.staticClass, "reorderVisually", "([BI[Ljava/lang/Object;II)V");
			global::java.text.Bidi._Bidi19357 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.text.Bidi._Bidi19358 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "<init>", "(Ljava/text/AttributedCharacterIterator;)V");
			global::java.text.Bidi._Bidi19359 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "<init>", "([CI[BIII)V");
		}
	}
}
