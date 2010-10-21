namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyEvent : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyEvent()
		{
			InitJNI();
		}
		protected KeyEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.KeyEvent.Callback_))]
		public interface Callback  : global::MonoJavaBridge.IJavaObject 
		{
			bool onKeyDown(int arg0, android.view.KeyEvent arg1);
			bool onKeyLongPress(int arg0, android.view.KeyEvent arg1);
			bool onKeyUp(int arg0, android.view.KeyEvent arg1);
			bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.KeyEvent.Callback))]
		public sealed partial class Callback_ : java.lang.Object, Callback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Callback_()
			{
				InitJNI();
			}
			internal Callback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onKeyDown14055;
			 bool android.view.KeyEvent.Callback.onKeyDown(int arg0, android.view.KeyEvent arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.Callback_._onKeyDown14055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.Callback_.staticClass, global::android.view.KeyEvent.Callback_._onKeyDown14055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onKeyLongPress14056;
			 bool android.view.KeyEvent.Callback.onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.Callback_._onKeyLongPress14056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.Callback_.staticClass, global::android.view.KeyEvent.Callback_._onKeyLongPress14056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onKeyUp14057;
			 bool android.view.KeyEvent.Callback.onKeyUp(int arg0, android.view.KeyEvent arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.Callback_._onKeyUp14057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.Callback_.staticClass, global::android.view.KeyEvent.Callback_._onKeyUp14057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onKeyMultiple14058;
			 bool android.view.KeyEvent.Callback.onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.Callback_._onKeyMultiple14058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.Callback_.staticClass, global::android.view.KeyEvent.Callback_._onKeyMultiple14058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.KeyEvent.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/KeyEvent$Callback"));
				global::android.view.KeyEvent.Callback_._onKeyDown14055 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.Callback_.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
				global::android.view.KeyEvent.Callback_._onKeyLongPress14056 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.Callback_.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
				global::android.view.KeyEvent.Callback_._onKeyUp14057 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.Callback_.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
				global::android.view.KeyEvent.Callback_._onKeyMultiple14058 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.Callback_.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class DispatcherState : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static DispatcherState()
			{
				InitJNI();
			}
			protected DispatcherState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _reset14059;
			public virtual void reset() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.KeyEvent.DispatcherState._reset14059);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.KeyEvent.DispatcherState.staticClass, global::android.view.KeyEvent.DispatcherState._reset14059);
			}
			internal static global::MonoJavaBridge.MethodId _reset14060;
			public virtual void reset(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.KeyEvent.DispatcherState._reset14060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.KeyEvent.DispatcherState.staticClass, global::android.view.KeyEvent.DispatcherState._reset14060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _startTracking14061;
			public virtual void startTracking(android.view.KeyEvent arg0, java.lang.Object arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.KeyEvent.DispatcherState._startTracking14061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.KeyEvent.DispatcherState.staticClass, global::android.view.KeyEvent.DispatcherState._startTracking14061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _isTracking14062;
			public virtual bool isTracking(android.view.KeyEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.DispatcherState._isTracking14062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.DispatcherState.staticClass, global::android.view.KeyEvent.DispatcherState._isTracking14062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _performedLongPress14063;
			public virtual void performedLongPress(android.view.KeyEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.KeyEvent.DispatcherState._performedLongPress14063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.KeyEvent.DispatcherState.staticClass, global::android.view.KeyEvent.DispatcherState._performedLongPress14063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _handleUpEvent14064;
			public virtual void handleUpEvent(android.view.KeyEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.KeyEvent.DispatcherState._handleUpEvent14064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.KeyEvent.DispatcherState.staticClass, global::android.view.KeyEvent.DispatcherState._handleUpEvent14064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _DispatcherState14065;
			public DispatcherState()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyEvent.DispatcherState.staticClass, global::android.view.KeyEvent.DispatcherState._DispatcherState14065);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.KeyEvent.DispatcherState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/KeyEvent$DispatcherState"));
				global::android.view.KeyEvent.DispatcherState._reset14059 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.DispatcherState.staticClass, "reset", "()V");
				global::android.view.KeyEvent.DispatcherState._reset14060 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.DispatcherState.staticClass, "reset", "(Ljava/lang/Object;)V");
				global::android.view.KeyEvent.DispatcherState._startTracking14061 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.DispatcherState.staticClass, "startTracking", "(Landroid/view/KeyEvent;Ljava/lang/Object;)V");
				global::android.view.KeyEvent.DispatcherState._isTracking14062 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.DispatcherState.staticClass, "isTracking", "(Landroid/view/KeyEvent;)Z");
				global::android.view.KeyEvent.DispatcherState._performedLongPress14063 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.DispatcherState.staticClass, "performedLongPress", "(Landroid/view/KeyEvent;)V");
				global::android.view.KeyEvent.DispatcherState._handleUpEvent14064 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.DispatcherState.staticClass, "handleUpEvent", "(Landroid/view/KeyEvent;)V");
				global::android.view.KeyEvent.DispatcherState._DispatcherState14065 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.DispatcherState.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _dispatch14066;
		public virtual bool dispatch(android.view.KeyEvent.Callback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyEvent._dispatch14066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._dispatch14066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatch14067;
		public virtual bool dispatch(android.view.KeyEvent.Callback arg0, android.view.KeyEvent.DispatcherState arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyEvent._dispatch14067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._dispatch14067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _toString14068;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.KeyEvent._toString14068)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._toString14068)) as java.lang.String;
		}
		public new char Number
		{
			get
			{
				return getNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNumber14069;
		public virtual char getNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.KeyEvent._getNumber14069);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getNumber14069);
		}
		public new long EventTime
		{
			get
			{
				return getEventTime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEventTime14070;
		public virtual long getEventTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.KeyEvent._getEventTime14070);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getEventTime14070);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel14071;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.KeyEvent._writeToParcel14071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._writeToParcel14071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents14072;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.KeyEvent._describeContents14072);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._describeContents14072);
		}
		public new int Action
		{
			get
			{
				return getAction();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAction14073;
		public virtual int getAction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.KeyEvent._getAction14073);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getAction14073);
		}
		public new int Flags
		{
			get
			{
				return getFlags();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFlags14074;
		public virtual int getFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.KeyEvent._getFlags14074);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getFlags14074);
		}
		public static int MaxKeyCode
		{
			get
			{
				return getMaxKeyCode();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxKeyCode14075;
		public static int getMaxKeyCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getMaxKeyCode14075);
		}
		internal static global::MonoJavaBridge.MethodId _getDeadChar14076;
		public static int getDeadChar(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getDeadChar14076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _changeTimeRepeat14077;
		public static global::android.view.KeyEvent changeTimeRepeat(android.view.KeyEvent arg0, long arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._changeTimeRepeat14077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.KeyEvent;
		}
		internal static global::MonoJavaBridge.MethodId _changeTimeRepeat14078;
		public static global::android.view.KeyEvent changeTimeRepeat(android.view.KeyEvent arg0, long arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._changeTimeRepeat14078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.KeyEvent;
		}
		internal static global::MonoJavaBridge.MethodId _changeAction14079;
		public static global::android.view.KeyEvent changeAction(android.view.KeyEvent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._changeAction14079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.KeyEvent;
		}
		internal static global::MonoJavaBridge.MethodId _changeFlags14080;
		public static global::android.view.KeyEvent changeFlags(android.view.KeyEvent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._changeFlags14080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.KeyEvent;
		}
		internal static global::MonoJavaBridge.MethodId _isSystem14081;
		public virtual bool isSystem() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyEvent._isSystem14081);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._isSystem14081);
		}
		public new int MetaState
		{
			get
			{
				return getMetaState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMetaState14082;
		public virtual int getMetaState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.KeyEvent._getMetaState14082);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getMetaState14082);
		}
		internal static global::MonoJavaBridge.MethodId _isModifierKey14083;
		public static bool isModifierKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._isModifierKey14083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAltPressed14084;
		public virtual bool isAltPressed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyEvent._isAltPressed14084);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._isAltPressed14084);
		}
		internal static global::MonoJavaBridge.MethodId _isShiftPressed14085;
		public virtual bool isShiftPressed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyEvent._isShiftPressed14085);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._isShiftPressed14085);
		}
		internal static global::MonoJavaBridge.MethodId _isSymPressed14086;
		public virtual bool isSymPressed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyEvent._isSymPressed14086);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._isSymPressed14086);
		}
		internal static global::MonoJavaBridge.MethodId _isCanceled14087;
		public virtual bool isCanceled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyEvent._isCanceled14087);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._isCanceled14087);
		}
		internal static global::MonoJavaBridge.MethodId _startTracking14088;
		public virtual void startTracking() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.KeyEvent._startTracking14088);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._startTracking14088);
		}
		internal static global::MonoJavaBridge.MethodId _isTracking14089;
		public virtual bool isTracking() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyEvent._isTracking14089);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._isTracking14089);
		}
		internal static global::MonoJavaBridge.MethodId _isLongPress14090;
		public virtual bool isLongPress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyEvent._isLongPress14090);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._isLongPress14090);
		}
		public new int KeyCode
		{
			get
			{
				return getKeyCode();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeyCode14091;
		public virtual int getKeyCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.KeyEvent._getKeyCode14091);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getKeyCode14091);
		}
		public new global::java.lang.String Characters
		{
			get
			{
				return getCharacters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCharacters14092;
		public virtual global::java.lang.String getCharacters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.KeyEvent._getCharacters14092)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getCharacters14092)) as java.lang.String;
		}
		public new int ScanCode
		{
			get
			{
				return getScanCode();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScanCode14093;
		public virtual int getScanCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.KeyEvent._getScanCode14093);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getScanCode14093);
		}
		public new int RepeatCount
		{
			get
			{
				return getRepeatCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRepeatCount14094;
		public virtual int getRepeatCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.KeyEvent._getRepeatCount14094);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getRepeatCount14094);
		}
		public new long DownTime
		{
			get
			{
				return getDownTime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDownTime14095;
		public virtual long getDownTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.KeyEvent._getDownTime14095);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getDownTime14095);
		}
		public new int DeviceId
		{
			get
			{
				return getDeviceId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeviceId14096;
		public virtual int getDeviceId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.KeyEvent._getDeviceId14096);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getDeviceId14096);
		}
		public new char DisplayLabel
		{
			get
			{
				return getDisplayLabel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayLabel14097;
		public virtual char getDisplayLabel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.KeyEvent._getDisplayLabel14097);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getDisplayLabel14097);
		}
		internal static global::MonoJavaBridge.MethodId _getUnicodeChar14098;
		public virtual int getUnicodeChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.KeyEvent._getUnicodeChar14098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getUnicodeChar14098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int UnicodeChar
		{
			get
			{
				return getUnicodeChar();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUnicodeChar14099;
		public virtual int getUnicodeChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.KeyEvent._getUnicodeChar14099);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getUnicodeChar14099);
		}
		internal static global::MonoJavaBridge.MethodId _getKeyData14100;
		public virtual bool getKeyData(android.view.KeyCharacterMap.KeyData arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyEvent._getKeyData14100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getKeyData14100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMatch14101;
		public virtual char getMatch(char[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.KeyEvent._getMatch14101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getMatch14101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMatch14102;
		public virtual char getMatch(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.KeyEvent._getMatch14102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getMatch14102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPrintingKey14103;
		public virtual bool isPrintingKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyEvent._isPrintingKey14103);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._isPrintingKey14103);
		}
		internal static global::MonoJavaBridge.MethodId _KeyEvent14104;
		public KeyEvent(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._KeyEvent14104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyEvent14105;
		public KeyEvent(long arg0, long arg1, int arg2, int arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._KeyEvent14105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyEvent14106;
		public KeyEvent(long arg0, long arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._KeyEvent14106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyEvent14107;
		public KeyEvent(long arg0, long arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._KeyEvent14107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyEvent14108;
		public KeyEvent(long arg0, long arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._KeyEvent14108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyEvent14109;
		public KeyEvent(long arg0, java.lang.String arg1, int arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._KeyEvent14109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyEvent14110;
		public KeyEvent(android.view.KeyEvent arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._KeyEvent14110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyEvent14111;
		public KeyEvent(android.view.KeyEvent arg0, long arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._KeyEvent14111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR14225;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.KeyEvent.staticClass, _CREATOR14225)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.KeyEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/KeyEvent"));
			global::android.view.KeyEvent._dispatch14066 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "dispatch", "(Landroid/view/KeyEvent$Callback;)Z");
			global::android.view.KeyEvent._dispatch14067 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "dispatch", "(Landroid/view/KeyEvent$Callback;Landroid/view/KeyEvent$DispatcherState;Ljava/lang/Object;)Z");
			global::android.view.KeyEvent._toString14068 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.KeyEvent._getNumber14069 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getNumber", "()C");
			global::android.view.KeyEvent._getEventTime14070 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getEventTime", "()J");
			global::android.view.KeyEvent._writeToParcel14071 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.KeyEvent._describeContents14072 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "describeContents", "()I");
			global::android.view.KeyEvent._getAction14073 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getAction", "()I");
			global::android.view.KeyEvent._getFlags14074 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getFlags", "()I");
			global::android.view.KeyEvent._getMaxKeyCode14075 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getMaxKeyCode", "()I");
			global::android.view.KeyEvent._getDeadChar14076 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getDeadChar", "(II)I");
			global::android.view.KeyEvent._changeTimeRepeat14077 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "changeTimeRepeat", "(Landroid/view/KeyEvent;JII)Landroid/view/KeyEvent;");
			global::android.view.KeyEvent._changeTimeRepeat14078 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "changeTimeRepeat", "(Landroid/view/KeyEvent;JI)Landroid/view/KeyEvent;");
			global::android.view.KeyEvent._changeAction14079 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "changeAction", "(Landroid/view/KeyEvent;I)Landroid/view/KeyEvent;");
			global::android.view.KeyEvent._changeFlags14080 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "changeFlags", "(Landroid/view/KeyEvent;I)Landroid/view/KeyEvent;");
			global::android.view.KeyEvent._isSystem14081 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "isSystem", "()Z");
			global::android.view.KeyEvent._getMetaState14082 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getMetaState", "()I");
			global::android.view.KeyEvent._isModifierKey14083 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "isModifierKey", "(I)Z");
			global::android.view.KeyEvent._isAltPressed14084 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "isAltPressed", "()Z");
			global::android.view.KeyEvent._isShiftPressed14085 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "isShiftPressed", "()Z");
			global::android.view.KeyEvent._isSymPressed14086 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "isSymPressed", "()Z");
			global::android.view.KeyEvent._isCanceled14087 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "isCanceled", "()Z");
			global::android.view.KeyEvent._startTracking14088 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "startTracking", "()V");
			global::android.view.KeyEvent._isTracking14089 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "isTracking", "()Z");
			global::android.view.KeyEvent._isLongPress14090 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "isLongPress", "()Z");
			global::android.view.KeyEvent._getKeyCode14091 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getKeyCode", "()I");
			global::android.view.KeyEvent._getCharacters14092 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getCharacters", "()Ljava/lang/String;");
			global::android.view.KeyEvent._getScanCode14093 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getScanCode", "()I");
			global::android.view.KeyEvent._getRepeatCount14094 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getRepeatCount", "()I");
			global::android.view.KeyEvent._getDownTime14095 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getDownTime", "()J");
			global::android.view.KeyEvent._getDeviceId14096 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getDeviceId", "()I");
			global::android.view.KeyEvent._getDisplayLabel14097 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getDisplayLabel", "()C");
			global::android.view.KeyEvent._getUnicodeChar14098 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getUnicodeChar", "(I)I");
			global::android.view.KeyEvent._getUnicodeChar14099 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getUnicodeChar", "()I");
			global::android.view.KeyEvent._getKeyData14100 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getKeyData", "(Landroid/view/KeyCharacterMap$KeyData;)Z");
			global::android.view.KeyEvent._getMatch14101 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getMatch", "([CI)C");
			global::android.view.KeyEvent._getMatch14102 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "getMatch", "([C)C");
			global::android.view.KeyEvent._isPrintingKey14103 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "isPrintingKey", "()Z");
			global::android.view.KeyEvent._KeyEvent14104 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "<init>", "(II)V");
			global::android.view.KeyEvent._KeyEvent14105 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "<init>", "(JJIII)V");
			global::android.view.KeyEvent._KeyEvent14106 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "<init>", "(JJIIII)V");
			global::android.view.KeyEvent._KeyEvent14107 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "<init>", "(JJIIIIII)V");
			global::android.view.KeyEvent._KeyEvent14108 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "<init>", "(JJIIIIIII)V");
			global::android.view.KeyEvent._KeyEvent14109 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "<init>", "(JLjava/lang/String;II)V");
			global::android.view.KeyEvent._KeyEvent14110 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "<init>", "(Landroid/view/KeyEvent;)V");
			global::android.view.KeyEvent._KeyEvent14111 = @__env.GetMethodIDNoThrow(global::android.view.KeyEvent.staticClass, "<init>", "(Landroid/view/KeyEvent;JI)V");
			global::android.view.KeyEvent._CREATOR14225 = @__env.GetStaticFieldIDNoThrow(global::android.view.KeyEvent.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
