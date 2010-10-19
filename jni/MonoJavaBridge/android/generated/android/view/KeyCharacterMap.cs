namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyCharacterMap : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyCharacterMap()
		{
			InitJNI();
		}
		protected KeyCharacterMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class KeyData : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static KeyData()
			{
				InitJNI();
			}
			protected KeyData(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _KeyData9312;
			public KeyData()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyCharacterMap.KeyData.staticClass, global::android.view.KeyCharacterMap.KeyData._KeyData9312);
				Init(@__env, handle);
			}
			public static int META_LENGTH
			{
				get
				{
					return 4;
				}
			}
			internal static global::MonoJavaBridge.FieldId _displayLabel9313;
			public char displayLabel
			{
				get
				{
					return default(char);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _number9314;
			public char number
			{
				get
				{
					return default(char);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _meta9315;
			public char[] meta
			{
				get
				{
					return default(char[]);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.KeyCharacterMap.KeyData.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/KeyCharacterMap$KeyData"));
				global::android.view.KeyCharacterMap.KeyData._KeyData9312 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.KeyData.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize9316;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.KeyCharacterMap._finalize9316);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._finalize9316);
		}
		internal static global::MonoJavaBridge.MethodId _get9317;
		public virtual int get(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.KeyCharacterMap._get9317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._get9317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _load9318;
		public static global::android.view.KeyCharacterMap load(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._load9318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.KeyCharacterMap;
		}
		internal static global::MonoJavaBridge.MethodId _getNumber9319;
		public virtual char getNumber(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getNumber9319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getNumber9319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDeadChar9320;
		public static int getDeadChar(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getDeadChar9320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayLabel9321;
		public virtual char getDisplayLabel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getDisplayLabel9321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getDisplayLabel9321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getKeyData9322;
		public virtual bool getKeyData(int arg0, android.view.KeyCharacterMap.KeyData arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getKeyData9322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getKeyData9322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMatch9323;
		public virtual char getMatch(int arg0, char[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getMatch9323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getMatch9323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getMatch9324;
		public virtual char getMatch(int arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getMatch9324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getMatch9324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isPrintingKey9325;
		public virtual bool isPrintingKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyCharacterMap._isPrintingKey9325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._isPrintingKey9325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEvents9326;
		public virtual global::android.view.KeyEvent[] getEvents(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.KeyEvent>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getEvents9326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.KeyEvent[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.KeyEvent>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getEvents9326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.KeyEvent[];
		}
		public new int KeyboardType
		{
			get
			{
				return getKeyboardType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeyboardType9327;
		public virtual int getKeyboardType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getKeyboardType9327);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getKeyboardType9327);
		}
		internal static global::MonoJavaBridge.MethodId _deviceHasKey9328;
		public static bool deviceHasKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._deviceHasKey9328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deviceHasKeys9329;
		public static bool[] deviceHasKeys(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallStaticObjectMethod(android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._deviceHasKeys9329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as bool[];
		}
		public static int BUILT_IN_KEYBOARD
		{
			get
			{
				return 0;
			}
		}
		public static int NUMERIC
		{
			get
			{
				return 1;
			}
		}
		public static int PREDICTIVE
		{
			get
			{
				return 2;
			}
		}
		public static int ALPHA
		{
			get
			{
				return 3;
			}
		}
		public static char HEX_INPUT
		{
			get
			{
				return '0';
			}
		}
		public static char PICKER_DIALOG_INPUT
		{
			get
			{
				return '0';
			}
		}
		public static int COMBINING_ACCENT
		{
			get
			{
				return -2147483648;
			}
		}
		public static int COMBINING_ACCENT_MASK
		{
			get
			{
				return 2147483647;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.KeyCharacterMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/KeyCharacterMap"));
			global::android.view.KeyCharacterMap._finalize9316 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "finalize", "()V");
			global::android.view.KeyCharacterMap._get9317 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "get", "(II)I");
			global::android.view.KeyCharacterMap._load9318 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "load", "(I)Landroid/view/KeyCharacterMap;");
			global::android.view.KeyCharacterMap._getNumber9319 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getNumber", "(I)C");
			global::android.view.KeyCharacterMap._getDeadChar9320 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getDeadChar", "(II)I");
			global::android.view.KeyCharacterMap._getDisplayLabel9321 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getDisplayLabel", "(I)C");
			global::android.view.KeyCharacterMap._getKeyData9322 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getKeyData", "(ILandroid/view/KeyCharacterMap$KeyData;)Z");
			global::android.view.KeyCharacterMap._getMatch9323 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getMatch", "(I[CI)C");
			global::android.view.KeyCharacterMap._getMatch9324 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getMatch", "(I[C)C");
			global::android.view.KeyCharacterMap._isPrintingKey9325 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "isPrintingKey", "(I)Z");
			global::android.view.KeyCharacterMap._getEvents9326 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getEvents", "([C)[Landroid/view/KeyEvent;");
			global::android.view.KeyCharacterMap._getKeyboardType9327 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getKeyboardType", "()I");
			global::android.view.KeyCharacterMap._deviceHasKey9328 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "deviceHasKey", "(I)Z");
			global::android.view.KeyCharacterMap._deviceHasKeys9329 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "deviceHasKeys", "([I)[Z");
		}
	}
}
