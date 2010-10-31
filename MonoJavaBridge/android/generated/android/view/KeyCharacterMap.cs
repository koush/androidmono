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
			private static global::MonoJavaBridge.MethodId _m0;
			public KeyData() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.KeyCharacterMap.KeyData._m0.native == global::System.IntPtr.Zero)
					global::android.view.KeyCharacterMap.KeyData._m0 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.KeyData.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyCharacterMap.KeyData.staticClass, global::android.view.KeyCharacterMap.KeyData._m0);
				Init(@__env, handle);
			}
			public static int META_LENGTH
			{
				get
				{
					return 4;
				}
			}
			internal static global::MonoJavaBridge.FieldId _displayLabel5494;
			public char displayLabel
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetCharField(this.JvmHandle, _displayLabel5494);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _number5495;
			public char number
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetCharField(this.JvmHandle, _number5495);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _meta5496;
			public char[] meta
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.GetObjectField(this.JvmHandle, _meta5496)) as char[];
				}
				set
				{
				}
			}
			static KeyData()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.KeyCharacterMap.KeyData.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/KeyCharacterMap$KeyData"));
				global::android.view.KeyCharacterMap.KeyData._displayLabel5494 = @__env.GetFieldIDNoThrow(global::android.view.KeyCharacterMap.KeyData.staticClass, "displayLabel", "C");
				global::android.view.KeyCharacterMap.KeyData._number5495 = @__env.GetFieldIDNoThrow(global::android.view.KeyCharacterMap.KeyData.staticClass, "number", "C");
				global::android.view.KeyCharacterMap.KeyData._meta5496 = @__env.GetFieldIDNoThrow(global::android.view.KeyCharacterMap.KeyData.staticClass, "meta", "[C");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.KeyCharacterMap.staticClass, "finalize", "()V", ref global::android.view.KeyCharacterMap._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int get(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.KeyCharacterMap.staticClass, "get", "(II)I", ref global::android.view.KeyCharacterMap._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::android.view.KeyCharacterMap load(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyCharacterMap._m2.native == global::System.IntPtr.Zero)
				global::android.view.KeyCharacterMap._m2 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "load", "(I)Landroid/view/KeyCharacterMap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.KeyCharacterMap;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual char getNumber(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.view.KeyCharacterMap.staticClass, "getNumber", "(I)C", ref global::android.view.KeyCharacterMap._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static int getDeadChar(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyCharacterMap._m4.native == global::System.IntPtr.Zero)
				global::android.view.KeyCharacterMap._m4 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getDeadChar", "(II)I");
			return @__env.CallStaticIntMethod(android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual char getDisplayLabel(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.view.KeyCharacterMap.staticClass, "getDisplayLabel", "(I)C", ref global::android.view.KeyCharacterMap._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool getKeyData(int arg0, android.view.KeyCharacterMap.KeyData arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.KeyCharacterMap.staticClass, "getKeyData", "(ILandroid/view/KeyCharacterMap$KeyData;)Z", ref global::android.view.KeyCharacterMap._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual char getMatch(int arg0, char[] arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.view.KeyCharacterMap.staticClass, "getMatch", "(I[CI)C", ref global::android.view.KeyCharacterMap._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual char getMatch(int arg0, char[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.view.KeyCharacterMap.staticClass, "getMatch", "(I[C)C", ref global::android.view.KeyCharacterMap._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool isPrintingKey(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.KeyCharacterMap.staticClass, "isPrintingKey", "(I)Z", ref global::android.view.KeyCharacterMap._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::android.view.KeyEvent[] getEvents(char[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.view.KeyEvent>(this, global::android.view.KeyCharacterMap.staticClass, "getEvents", "([C)[Landroid/view/KeyEvent;", ref global::android.view.KeyCharacterMap._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.KeyEvent[];
		}
		public new int KeyboardType
		{
			get
			{
				return getKeyboardType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getKeyboardType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.KeyCharacterMap.staticClass, "getKeyboardType", "()I", ref global::android.view.KeyCharacterMap._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static bool deviceHasKey(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyCharacterMap._m12.native == global::System.IntPtr.Zero)
				global::android.view.KeyCharacterMap._m12 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "deviceHasKey", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static bool[] deviceHasKeys(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyCharacterMap._m13.native == global::System.IntPtr.Zero)
				global::android.view.KeyCharacterMap._m13 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "deviceHasKeys", "([I)[Z");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallStaticObjectMethod(android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as bool[];
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
		}
	}
}
