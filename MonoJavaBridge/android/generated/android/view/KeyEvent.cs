namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyEvent : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.KeyEvent.Callback_))]
		public partial interface Callback  : global::MonoJavaBridge.IJavaObject 
		{
			bool onKeyDown(int arg0, android.view.KeyEvent arg1);
			bool onKeyLongPress(int arg0, android.view.KeyEvent arg1);
			bool onKeyUp(int arg0, android.view.KeyEvent arg1);
			bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.KeyEvent.Callback))]
		internal sealed partial class Callback_ : java.lang.Object, Callback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Callback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.view.KeyEvent.Callback.onKeyDown(int arg0, android.view.KeyEvent arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.KeyEvent.Callback_.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.view.KeyEvent.Callback_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			bool android.view.KeyEvent.Callback.onKeyLongPress(int arg0, android.view.KeyEvent arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.KeyEvent.Callback_.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", ref global::android.view.KeyEvent.Callback_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			bool android.view.KeyEvent.Callback.onKeyUp(int arg0, android.view.KeyEvent arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.KeyEvent.Callback_.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.view.KeyEvent.Callback_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			bool android.view.KeyEvent.Callback.onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.KeyEvent.Callback_.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", ref global::android.view.KeyEvent.Callback_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static Callback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.KeyEvent.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/KeyEvent$Callback"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class DispatcherState : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected DispatcherState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void reset()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.KeyEvent.DispatcherState.staticClass, "reset", "()V", ref global::android.view.KeyEvent.DispatcherState._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual void reset(java.lang.Object arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.KeyEvent.DispatcherState.staticClass, "reset", "(Ljava/lang/Object;)V", ref global::android.view.KeyEvent.DispatcherState._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual void startTracking(android.view.KeyEvent arg0, java.lang.Object arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.KeyEvent.DispatcherState.staticClass, "startTracking", "(Landroid/view/KeyEvent;Ljava/lang/Object;)V", ref global::android.view.KeyEvent.DispatcherState._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual bool isTracking(android.view.KeyEvent arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.KeyEvent.DispatcherState.staticClass, "isTracking", "(Landroid/view/KeyEvent;)Z", ref global::android.view.KeyEvent.DispatcherState._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual void performedLongPress(android.view.KeyEvent arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.KeyEvent.DispatcherState.staticClass, "performedLongPress", "(Landroid/view/KeyEvent;)V", ref global::android.view.KeyEvent.DispatcherState._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual void handleUpEvent(android.view.KeyEvent arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.KeyEvent.DispatcherState.staticClass, "handleUpEvent", "(Landroid/view/KeyEvent;)V", ref global::android.view.KeyEvent.DispatcherState._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public DispatcherState() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.KeyEvent.DispatcherState._m6.native == global::System.IntPtr.Zero)
					global::android.view.KeyEvent.DispatcherState._m6 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.DispatcherState.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyEvent.DispatcherState.staticClass, global::android.view.KeyEvent.DispatcherState._m6);
				Init(@__env, handle);
			}
			static DispatcherState()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.KeyEvent.DispatcherState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/KeyEvent$DispatcherState"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool dispatch(android.view.KeyEvent.Callback arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.KeyEvent.staticClass, "dispatch", "(Landroid/view/KeyEvent$Callback;)Z", ref global::android.view.KeyEvent._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool dispatch(android.view.KeyEvent.Callback arg0, android.view.KeyEvent.DispatcherState arg1, java.lang.Object arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.KeyEvent.staticClass, "dispatch", "(Landroid/view/KeyEvent$Callback;Landroid/view/KeyEvent$DispatcherState;Ljava/lang/Object;)Z", ref global::android.view.KeyEvent._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.KeyEvent.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.KeyEvent._m2) as java.lang.String;
		}
		public new char Number
		{
			get
			{
				return getNumber();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual char getNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.view.KeyEvent.staticClass, "getNumber", "()C", ref global::android.view.KeyEvent._m3);
		}
		public new long EventTime
		{
			get
			{
				return getEventTime();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual long getEventTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.KeyEvent.staticClass, "getEventTime", "()J", ref global::android.view.KeyEvent._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.KeyEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.view.KeyEvent._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.KeyEvent.staticClass, "describeContents", "()I", ref global::android.view.KeyEvent._m6);
		}
		public new int Action
		{
			get
			{
				return getAction();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getAction()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.KeyEvent.staticClass, "getAction", "()I", ref global::android.view.KeyEvent._m7);
		}
		public new int Flags
		{
			get
			{
				return getFlags();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int getFlags()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.KeyEvent.staticClass, "getFlags", "()I", ref global::android.view.KeyEvent._m8);
		}
		public static int MaxKeyCode
		{
			get
			{
				return getMaxKeyCode();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static int getMaxKeyCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyEvent._m9.native == global::System.IntPtr.Zero)
				global::android.view.KeyEvent._m9 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getMaxKeyCode", "()I");
			return @__env.CallStaticIntMethod(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static int getDeadChar(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyEvent._m10.native == global::System.IntPtr.Zero)
				global::android.view.KeyEvent._m10 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getDeadChar", "(II)I");
			return @__env.CallStaticIntMethod(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::android.view.KeyEvent changeTimeRepeat(android.view.KeyEvent arg0, long arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyEvent._m11.native == global::System.IntPtr.Zero)
				global::android.view.KeyEvent._m11 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "changeTimeRepeat", "(Landroid/view/KeyEvent;JII)Landroid/view/KeyEvent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.KeyEvent;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::android.view.KeyEvent changeTimeRepeat(android.view.KeyEvent arg0, long arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyEvent._m12.native == global::System.IntPtr.Zero)
				global::android.view.KeyEvent._m12 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "changeTimeRepeat", "(Landroid/view/KeyEvent;JI)Landroid/view/KeyEvent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.KeyEvent;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::android.view.KeyEvent changeAction(android.view.KeyEvent arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyEvent._m13.native == global::System.IntPtr.Zero)
				global::android.view.KeyEvent._m13 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "changeAction", "(Landroid/view/KeyEvent;I)Landroid/view/KeyEvent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.KeyEvent;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::android.view.KeyEvent changeFlags(android.view.KeyEvent arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyEvent._m14.native == global::System.IntPtr.Zero)
				global::android.view.KeyEvent._m14 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "changeFlags", "(Landroid/view/KeyEvent;I)Landroid/view/KeyEvent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.KeyEvent;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool isSystem()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.KeyEvent.staticClass, "isSystem", "()Z", ref global::android.view.KeyEvent._m15);
		}
		public new int MetaState
		{
			get
			{
				return getMetaState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int getMetaState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.KeyEvent.staticClass, "getMetaState", "()I", ref global::android.view.KeyEvent._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static bool isModifierKey(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyEvent._m17.native == global::System.IntPtr.Zero)
				global::android.view.KeyEvent._m17 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "isModifierKey", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual bool isAltPressed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.KeyEvent.staticClass, "isAltPressed", "()Z", ref global::android.view.KeyEvent._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool isShiftPressed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.KeyEvent.staticClass, "isShiftPressed", "()Z", ref global::android.view.KeyEvent._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool isSymPressed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.KeyEvent.staticClass, "isSymPressed", "()Z", ref global::android.view.KeyEvent._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool isCanceled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.KeyEvent.staticClass, "isCanceled", "()Z", ref global::android.view.KeyEvent._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void startTracking()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.KeyEvent.staticClass, "startTracking", "()V", ref global::android.view.KeyEvent._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool isTracking()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.KeyEvent.staticClass, "isTracking", "()Z", ref global::android.view.KeyEvent._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual bool isLongPress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.KeyEvent.staticClass, "isLongPress", "()Z", ref global::android.view.KeyEvent._m24);
		}
		public new int KeyCode
		{
			get
			{
				return getKeyCode();
			}
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual int getKeyCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.KeyEvent.staticClass, "getKeyCode", "()I", ref global::android.view.KeyEvent._m25);
		}
		public new global::java.lang.String Characters
		{
			get
			{
				return getCharacters();
			}
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::java.lang.String getCharacters()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.KeyEvent.staticClass, "getCharacters", "()Ljava/lang/String;", ref global::android.view.KeyEvent._m26) as java.lang.String;
		}
		public new int ScanCode
		{
			get
			{
				return getScanCode();
			}
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual int getScanCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.KeyEvent.staticClass, "getScanCode", "()I", ref global::android.view.KeyEvent._m27);
		}
		public new int RepeatCount
		{
			get
			{
				return getRepeatCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual int getRepeatCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.KeyEvent.staticClass, "getRepeatCount", "()I", ref global::android.view.KeyEvent._m28);
		}
		public new long DownTime
		{
			get
			{
				return getDownTime();
			}
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual long getDownTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.KeyEvent.staticClass, "getDownTime", "()J", ref global::android.view.KeyEvent._m29);
		}
		public new int DeviceId
		{
			get
			{
				return getDeviceId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual int getDeviceId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.KeyEvent.staticClass, "getDeviceId", "()I", ref global::android.view.KeyEvent._m30);
		}
		public new char DisplayLabel
		{
			get
			{
				return getDisplayLabel();
			}
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual char getDisplayLabel()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.view.KeyEvent.staticClass, "getDisplayLabel", "()C", ref global::android.view.KeyEvent._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual int getUnicodeChar(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.KeyEvent.staticClass, "getUnicodeChar", "(I)I", ref global::android.view.KeyEvent._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int UnicodeChar
		{
			get
			{
				return getUnicodeChar();
			}
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual int getUnicodeChar()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.KeyEvent.staticClass, "getUnicodeChar", "()I", ref global::android.view.KeyEvent._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual bool getKeyData(android.view.KeyCharacterMap.KeyData arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.KeyEvent.staticClass, "getKeyData", "(Landroid/view/KeyCharacterMap$KeyData;)Z", ref global::android.view.KeyEvent._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual char getMatch(char[] arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.view.KeyEvent.staticClass, "getMatch", "([CI)C", ref global::android.view.KeyEvent._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual char getMatch(char[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.view.KeyEvent.staticClass, "getMatch", "([C)C", ref global::android.view.KeyEvent._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual bool isPrintingKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.KeyEvent.staticClass, "isPrintingKey", "()Z", ref global::android.view.KeyEvent._m37);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public KeyEvent(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyEvent._m38.native == global::System.IntPtr.Zero)
				global::android.view.KeyEvent._m38 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public KeyEvent(long arg0, long arg1, int arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyEvent._m39.native == global::System.IntPtr.Zero)
				global::android.view.KeyEvent._m39 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "<init>", "(JJIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public KeyEvent(long arg0, long arg1, int arg2, int arg3, int arg4, int arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyEvent._m40.native == global::System.IntPtr.Zero)
				global::android.view.KeyEvent._m40 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "<init>", "(JJIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public KeyEvent(long arg0, long arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyEvent._m41.native == global::System.IntPtr.Zero)
				global::android.view.KeyEvent._m41 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "<init>", "(JJIIIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public KeyEvent(long arg0, long arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyEvent._m42.native == global::System.IntPtr.Zero)
				global::android.view.KeyEvent._m42 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "<init>", "(JJIIIIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public KeyEvent(long arg0, java.lang.String arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyEvent._m43.native == global::System.IntPtr.Zero)
				global::android.view.KeyEvent._m43 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "<init>", "(JLjava/lang/String;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public KeyEvent(android.view.KeyEvent arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyEvent._m44.native == global::System.IntPtr.Zero)
				global::android.view.KeyEvent._m44 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "<init>", "(Landroid/view/KeyEvent;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public KeyEvent(android.view.KeyEvent arg0, long arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.KeyEvent._m45.native == global::System.IntPtr.Zero)
				global::android.view.KeyEvent._m45 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "<init>", "(Landroid/view/KeyEvent;JI)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static int KEYCODE_UNKNOWN
		{
			get
			{
				return 0;
			}
		}
		public static int KEYCODE_SOFT_LEFT
		{
			get
			{
				return 1;
			}
		}
		public static int KEYCODE_SOFT_RIGHT
		{
			get
			{
				return 2;
			}
		}
		public static int KEYCODE_HOME
		{
			get
			{
				return 3;
			}
		}
		public static int KEYCODE_BACK
		{
			get
			{
				return 4;
			}
		}
		public static int KEYCODE_CALL
		{
			get
			{
				return 5;
			}
		}
		public static int KEYCODE_ENDCALL
		{
			get
			{
				return 6;
			}
		}
		public static int KEYCODE_0
		{
			get
			{
				return 7;
			}
		}
		public static int KEYCODE_1
		{
			get
			{
				return 8;
			}
		}
		public static int KEYCODE_2
		{
			get
			{
				return 9;
			}
		}
		public static int KEYCODE_3
		{
			get
			{
				return 10;
			}
		}
		public static int KEYCODE_4
		{
			get
			{
				return 11;
			}
		}
		public static int KEYCODE_5
		{
			get
			{
				return 12;
			}
		}
		public static int KEYCODE_6
		{
			get
			{
				return 13;
			}
		}
		public static int KEYCODE_7
		{
			get
			{
				return 14;
			}
		}
		public static int KEYCODE_8
		{
			get
			{
				return 15;
			}
		}
		public static int KEYCODE_9
		{
			get
			{
				return 16;
			}
		}
		public static int KEYCODE_STAR
		{
			get
			{
				return 17;
			}
		}
		public static int KEYCODE_POUND
		{
			get
			{
				return 18;
			}
		}
		public static int KEYCODE_DPAD_UP
		{
			get
			{
				return 19;
			}
		}
		public static int KEYCODE_DPAD_DOWN
		{
			get
			{
				return 20;
			}
		}
		public static int KEYCODE_DPAD_LEFT
		{
			get
			{
				return 21;
			}
		}
		public static int KEYCODE_DPAD_RIGHT
		{
			get
			{
				return 22;
			}
		}
		public static int KEYCODE_DPAD_CENTER
		{
			get
			{
				return 23;
			}
		}
		public static int KEYCODE_VOLUME_UP
		{
			get
			{
				return 24;
			}
		}
		public static int KEYCODE_VOLUME_DOWN
		{
			get
			{
				return 25;
			}
		}
		public static int KEYCODE_POWER
		{
			get
			{
				return 26;
			}
		}
		public static int KEYCODE_CAMERA
		{
			get
			{
				return 27;
			}
		}
		public static int KEYCODE_CLEAR
		{
			get
			{
				return 28;
			}
		}
		public static int KEYCODE_A
		{
			get
			{
				return 29;
			}
		}
		public static int KEYCODE_B
		{
			get
			{
				return 30;
			}
		}
		public static int KEYCODE_C
		{
			get
			{
				return 31;
			}
		}
		public static int KEYCODE_D
		{
			get
			{
				return 32;
			}
		}
		public static int KEYCODE_E
		{
			get
			{
				return 33;
			}
		}
		public static int KEYCODE_F
		{
			get
			{
				return 34;
			}
		}
		public static int KEYCODE_G
		{
			get
			{
				return 35;
			}
		}
		public static int KEYCODE_H
		{
			get
			{
				return 36;
			}
		}
		public static int KEYCODE_I
		{
			get
			{
				return 37;
			}
		}
		public static int KEYCODE_J
		{
			get
			{
				return 38;
			}
		}
		public static int KEYCODE_K
		{
			get
			{
				return 39;
			}
		}
		public static int KEYCODE_L
		{
			get
			{
				return 40;
			}
		}
		public static int KEYCODE_M
		{
			get
			{
				return 41;
			}
		}
		public static int KEYCODE_N
		{
			get
			{
				return 42;
			}
		}
		public static int KEYCODE_O
		{
			get
			{
				return 43;
			}
		}
		public static int KEYCODE_P
		{
			get
			{
				return 44;
			}
		}
		public static int KEYCODE_Q
		{
			get
			{
				return 45;
			}
		}
		public static int KEYCODE_R
		{
			get
			{
				return 46;
			}
		}
		public static int KEYCODE_S
		{
			get
			{
				return 47;
			}
		}
		public static int KEYCODE_T
		{
			get
			{
				return 48;
			}
		}
		public static int KEYCODE_U
		{
			get
			{
				return 49;
			}
		}
		public static int KEYCODE_V
		{
			get
			{
				return 50;
			}
		}
		public static int KEYCODE_W
		{
			get
			{
				return 51;
			}
		}
		public static int KEYCODE_X
		{
			get
			{
				return 52;
			}
		}
		public static int KEYCODE_Y
		{
			get
			{
				return 53;
			}
		}
		public static int KEYCODE_Z
		{
			get
			{
				return 54;
			}
		}
		public static int KEYCODE_COMMA
		{
			get
			{
				return 55;
			}
		}
		public static int KEYCODE_PERIOD
		{
			get
			{
				return 56;
			}
		}
		public static int KEYCODE_ALT_LEFT
		{
			get
			{
				return 57;
			}
		}
		public static int KEYCODE_ALT_RIGHT
		{
			get
			{
				return 58;
			}
		}
		public static int KEYCODE_SHIFT_LEFT
		{
			get
			{
				return 59;
			}
		}
		public static int KEYCODE_SHIFT_RIGHT
		{
			get
			{
				return 60;
			}
		}
		public static int KEYCODE_TAB
		{
			get
			{
				return 61;
			}
		}
		public static int KEYCODE_SPACE
		{
			get
			{
				return 62;
			}
		}
		public static int KEYCODE_SYM
		{
			get
			{
				return 63;
			}
		}
		public static int KEYCODE_EXPLORER
		{
			get
			{
				return 64;
			}
		}
		public static int KEYCODE_ENVELOPE
		{
			get
			{
				return 65;
			}
		}
		public static int KEYCODE_ENTER
		{
			get
			{
				return 66;
			}
		}
		public static int KEYCODE_DEL
		{
			get
			{
				return 67;
			}
		}
		public static int KEYCODE_GRAVE
		{
			get
			{
				return 68;
			}
		}
		public static int KEYCODE_MINUS
		{
			get
			{
				return 69;
			}
		}
		public static int KEYCODE_EQUALS
		{
			get
			{
				return 70;
			}
		}
		public static int KEYCODE_LEFT_BRACKET
		{
			get
			{
				return 71;
			}
		}
		public static int KEYCODE_RIGHT_BRACKET
		{
			get
			{
				return 72;
			}
		}
		public static int KEYCODE_BACKSLASH
		{
			get
			{
				return 73;
			}
		}
		public static int KEYCODE_SEMICOLON
		{
			get
			{
				return 74;
			}
		}
		public static int KEYCODE_APOSTROPHE
		{
			get
			{
				return 75;
			}
		}
		public static int KEYCODE_SLASH
		{
			get
			{
				return 76;
			}
		}
		public static int KEYCODE_AT
		{
			get
			{
				return 77;
			}
		}
		public static int KEYCODE_NUM
		{
			get
			{
				return 78;
			}
		}
		public static int KEYCODE_HEADSETHOOK
		{
			get
			{
				return 79;
			}
		}
		public static int KEYCODE_FOCUS
		{
			get
			{
				return 80;
			}
		}
		public static int KEYCODE_PLUS
		{
			get
			{
				return 81;
			}
		}
		public static int KEYCODE_MENU
		{
			get
			{
				return 82;
			}
		}
		public static int KEYCODE_NOTIFICATION
		{
			get
			{
				return 83;
			}
		}
		public static int KEYCODE_SEARCH
		{
			get
			{
				return 84;
			}
		}
		public static int KEYCODE_MEDIA_PLAY_PAUSE
		{
			get
			{
				return 85;
			}
		}
		public static int KEYCODE_MEDIA_STOP
		{
			get
			{
				return 86;
			}
		}
		public static int KEYCODE_MEDIA_NEXT
		{
			get
			{
				return 87;
			}
		}
		public static int KEYCODE_MEDIA_PREVIOUS
		{
			get
			{
				return 88;
			}
		}
		public static int KEYCODE_MEDIA_REWIND
		{
			get
			{
				return 89;
			}
		}
		public static int KEYCODE_MEDIA_FAST_FORWARD
		{
			get
			{
				return 90;
			}
		}
		public static int KEYCODE_MUTE
		{
			get
			{
				return 91;
			}
		}
		public static int MAX_KEYCODE
		{
			get
			{
				return 84;
			}
		}
		public static int ACTION_DOWN
		{
			get
			{
				return 0;
			}
		}
		public static int ACTION_UP
		{
			get
			{
				return 1;
			}
		}
		public static int ACTION_MULTIPLE
		{
			get
			{
				return 2;
			}
		}
		public static int META_ALT_ON
		{
			get
			{
				return 2;
			}
		}
		public static int META_ALT_LEFT_ON
		{
			get
			{
				return 16;
			}
		}
		public static int META_ALT_RIGHT_ON
		{
			get
			{
				return 32;
			}
		}
		public static int META_SHIFT_ON
		{
			get
			{
				return 1;
			}
		}
		public static int META_SHIFT_LEFT_ON
		{
			get
			{
				return 64;
			}
		}
		public static int META_SHIFT_RIGHT_ON
		{
			get
			{
				return 128;
			}
		}
		public static int META_SYM_ON
		{
			get
			{
				return 4;
			}
		}
		public static int FLAG_WOKE_HERE
		{
			get
			{
				return 1;
			}
		}
		public static int FLAG_SOFT_KEYBOARD
		{
			get
			{
				return 2;
			}
		}
		public static int FLAG_KEEP_TOUCH_MODE
		{
			get
			{
				return 4;
			}
		}
		public static int FLAG_FROM_SYSTEM
		{
			get
			{
				return 8;
			}
		}
		public static int FLAG_EDITOR_ACTION
		{
			get
			{
				return 16;
			}
		}
		public static int FLAG_CANCELED
		{
			get
			{
				return 32;
			}
		}
		public static int FLAG_VIRTUAL_HARD_KEY
		{
			get
			{
				return 64;
			}
		}
		public static int FLAG_LONG_PRESS
		{
			get
			{
				return 128;
			}
		}
		public static int FLAG_CANCELED_LONG_PRESS
		{
			get
			{
				return 256;
			}
		}
		public static int FLAG_TRACKING
		{
			get
			{
				return 512;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR5618;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.KeyEvent.staticClass, _CREATOR5618)) as android.os.Parcelable_Creator;
			}
		}
		static KeyEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.KeyEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/KeyEvent"));
			global::android.view.KeyEvent._CREATOR5618 = @__env.GetStaticFieldIDNoThrow(global::android.view.KeyEvent.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
