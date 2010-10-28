namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyCharacterMap : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyCharacterMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class KeyData : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected KeyData(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _KeyData14093;
			public KeyData() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyCharacterMap.KeyData.staticClass, global::android.view.KeyCharacterMap.KeyData._KeyData14093);
				Init(@__env, handle);
			}
			public static int META_LENGTH
			{
				get
				{
					return 4;
				}
			}
			internal static global::MonoJavaBridge.FieldId _displayLabel14095;
			public char displayLabel
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetCharField(this.JvmHandle, _displayLabel14095);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _number14096;
			public char number
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetCharField(this.JvmHandle, _number14096);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _meta14097;
			public char[] meta
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.GetObjectField(this.JvmHandle, _meta14097)) as char[];
				}
				set
				{
				}
			}
			static KeyData()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.KeyCharacterMap.KeyData.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/KeyCharacterMap$KeyData"));
				global::android.view.KeyCharacterMap.KeyData._KeyData14093 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.KeyData.staticClass, "<init>", "()V");
				global::android.view.KeyCharacterMap.KeyData._displayLabel14095 = @__env.GetFieldIDNoThrow(global::android.view.KeyCharacterMap.KeyData.staticClass, "displayLabel", "C");
				global::android.view.KeyCharacterMap.KeyData._number14096 = @__env.GetFieldIDNoThrow(global::android.view.KeyCharacterMap.KeyData.staticClass, "number", "C");
				global::android.view.KeyCharacterMap.KeyData._meta14097 = @__env.GetFieldIDNoThrow(global::android.view.KeyCharacterMap.KeyData.staticClass, "meta", "[C");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize14098;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.KeyCharacterMap._finalize14098);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._finalize14098);
		}
		internal static global::MonoJavaBridge.MethodId _get14099;
		public virtual int get(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.KeyCharacterMap._get14099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._get14099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _load14100;
		public static global::android.view.KeyCharacterMap load(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._load14100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.KeyCharacterMap;
		}
		internal static global::MonoJavaBridge.MethodId _getNumber14101;
		public virtual char getNumber(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getNumber14101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getNumber14101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDeadChar14102;
		public static int getDeadChar(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getDeadChar14102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayLabel14103;
		public virtual char getDisplayLabel(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getDisplayLabel14103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getDisplayLabel14103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getKeyData14104;
		public virtual bool getKeyData(int arg0, android.view.KeyCharacterMap.KeyData arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getKeyData14104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getKeyData14104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMatch14105;
		public virtual char getMatch(int arg0, char[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getMatch14105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getMatch14105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getMatch14106;
		public virtual char getMatch(int arg0, char[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getMatch14106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getMatch14106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isPrintingKey14107;
		public virtual bool isPrintingKey(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyCharacterMap._isPrintingKey14107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._isPrintingKey14107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEvents14108;
		public virtual global::android.view.KeyEvent[] getEvents(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.KeyEvent>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getEvents14108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.KeyEvent[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.KeyEvent>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getEvents14108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.KeyEvent[];
		}
		public new int KeyboardType
		{
			get
			{
				return getKeyboardType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeyboardType14109;
		public virtual int getKeyboardType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getKeyboardType14109);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getKeyboardType14109);
		}
		internal static global::MonoJavaBridge.MethodId _deviceHasKey14110;
		public static bool deviceHasKey(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._deviceHasKey14110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deviceHasKeys14111;
		public static bool[] deviceHasKeys(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallStaticObjectMethod(android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._deviceHasKeys14111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as bool[];
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
		static KeyCharacterMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.KeyCharacterMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/KeyCharacterMap"));
			global::android.view.KeyCharacterMap._finalize14098 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "finalize", "()V");
			global::android.view.KeyCharacterMap._get14099 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "get", "(II)I");
			global::android.view.KeyCharacterMap._load14100 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "load", "(I)Landroid/view/KeyCharacterMap;");
			global::android.view.KeyCharacterMap._getNumber14101 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getNumber", "(I)C");
			global::android.view.KeyCharacterMap._getDeadChar14102 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getDeadChar", "(II)I");
			global::android.view.KeyCharacterMap._getDisplayLabel14103 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getDisplayLabel", "(I)C");
			global::android.view.KeyCharacterMap._getKeyData14104 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getKeyData", "(ILandroid/view/KeyCharacterMap$KeyData;)Z");
			global::android.view.KeyCharacterMap._getMatch14105 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getMatch", "(I[CI)C");
			global::android.view.KeyCharacterMap._getMatch14106 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getMatch", "(I[C)C");
			global::android.view.KeyCharacterMap._isPrintingKey14107 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "isPrintingKey", "(I)Z");
			global::android.view.KeyCharacterMap._getEvents14108 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getEvents", "([C)[Landroid/view/KeyEvent;");
			global::android.view.KeyCharacterMap._getKeyboardType14109 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getKeyboardType", "()I");
			global::android.view.KeyCharacterMap._deviceHasKey14110 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "deviceHasKey", "(I)Z");
			global::android.view.KeyCharacterMap._deviceHasKeys14111 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "deviceHasKeys", "([I)[Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
