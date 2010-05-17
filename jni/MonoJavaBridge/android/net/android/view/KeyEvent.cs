namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class KeyEvent : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static KeyEvent() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.KeyEvent), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.KeyEvent(@__env); 
			} 
		} 
		protected KeyEvent(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface Callback 
		{ 
			bool onKeyDown(int arg0, android.view.KeyEvent arg1); 
			bool onKeyLongPress(int arg0, android.view.KeyEvent arg1); 
			bool onKeyUp(int arg0, android.view.KeyEvent arg1); 
			bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2); 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class DispatcherState : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static DispatcherState() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.KeyEvent.DispatcherState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.KeyEvent.DispatcherState(@__env); 
				} 
			} 
			protected DispatcherState(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _reset7361; 
			public virtual void reset() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.KeyEvent.DispatcherState)) 
					@__env.CallVoidMethod(this, _reset7361); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.view.KeyEvent.DispatcherState.staticClass, _reset7361); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _reset7362; 
			public virtual void reset(java.lang.Object arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.KeyEvent.DispatcherState)) 
					@__env.CallVoidMethod(this, _reset7362, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.view.KeyEvent.DispatcherState.staticClass, _reset7362, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _startTracking7363; 
			public virtual void startTracking(android.view.KeyEvent arg0, java.lang.Object arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.KeyEvent.DispatcherState)) 
					@__env.CallVoidMethod(this, _startTracking7363, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.view.KeyEvent.DispatcherState.staticClass, _startTracking7363, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isTracking7364; 
			public virtual bool isTracking(android.view.KeyEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.KeyEvent.DispatcherState)) 
					return @__env.CallBooleanMethod(this, _isTracking7364, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.view.KeyEvent.DispatcherState.staticClass, _isTracking7364, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _performedLongPress7365; 
			public virtual void performedLongPress(android.view.KeyEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.KeyEvent.DispatcherState)) 
					@__env.CallVoidMethod(this, _performedLongPress7365, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.view.KeyEvent.DispatcherState.staticClass, _performedLongPress7365, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _handleUpEvent7366; 
			public virtual void handleUpEvent(android.view.KeyEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.KeyEvent.DispatcherState)) 
					@__env.CallVoidMethod(this, _handleUpEvent7366, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.view.KeyEvent.DispatcherState.staticClass, _handleUpEvent7366, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _DispatcherState7367; 
			public DispatcherState()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.KeyEvent.DispatcherState.staticClass, _DispatcherState7367, this); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.KeyEvent.DispatcherState.staticClass = @__class; 
				global::android.view.KeyEvent.DispatcherState._reset7361 = @__env.GetMethodID(global::android.view.KeyEvent.DispatcherState.staticClass, "reset", "()V"); 
				global::android.view.KeyEvent.DispatcherState._reset7362 = @__env.GetMethodID(global::android.view.KeyEvent.DispatcherState.staticClass, "reset", "(Ljava/lang/Object;)V"); 
				global::android.view.KeyEvent.DispatcherState._startTracking7363 = @__env.GetMethodID(global::android.view.KeyEvent.DispatcherState.staticClass, "startTracking", "(Landroid/view/KeyEvent;Ljava/lang/Object;)V"); 
				global::android.view.KeyEvent.DispatcherState._isTracking7364 = @__env.GetMethodID(global::android.view.KeyEvent.DispatcherState.staticClass, "isTracking", "(Landroid/view/KeyEvent;)Z"); 
				global::android.view.KeyEvent.DispatcherState._performedLongPress7365 = @__env.GetMethodID(global::android.view.KeyEvent.DispatcherState.staticClass, "performedLongPress", "(Landroid/view/KeyEvent;)V"); 
				global::android.view.KeyEvent.DispatcherState._handleUpEvent7366 = @__env.GetMethodID(global::android.view.KeyEvent.DispatcherState.staticClass, "handleUpEvent", "(Landroid/view/KeyEvent;)V"); 
				global::android.view.KeyEvent.DispatcherState._DispatcherState7367 = @__env.GetMethodID(global::android.view.KeyEvent.DispatcherState.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatch7368; 
		public virtual bool dispatch(android.view.KeyEvent.Callback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallBooleanMethod(this, _dispatch7368, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.KeyEvent.staticClass, _dispatch7368, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatch7369; 
		public virtual bool dispatch(android.view.KeyEvent.Callback arg0, android.view.KeyEvent.DispatcherState arg1, java.lang.Object arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallBooleanMethod(this, _dispatch7369, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.KeyEvent.staticClass, _dispatch7369, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString7370; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString7370)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.KeyEvent.staticClass, _toString7370)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumber7371; 
		public virtual char getNumber() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallCharMethod(this, _getNumber7371); 
			else 
				return @__env.CallNonVirtualCharMethod(this, android.view.KeyEvent.staticClass, _getNumber7371); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEventTime7372; 
		public virtual long getEventTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallLongMethod(this, _getEventTime7372); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.view.KeyEvent.staticClass, _getEventTime7372); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7373; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				@__env.CallVoidMethod(this, _writeToParcel7373, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.KeyEvent.staticClass, _writeToParcel7373, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7374; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallIntMethod(this, _describeContents7374); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.KeyEvent.staticClass, _describeContents7374); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAction7375; 
		public virtual int getAction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallIntMethod(this, _getAction7375); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.KeyEvent.staticClass, _getAction7375); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFlags7376; 
		public virtual int getFlags() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallIntMethod(this, _getFlags7376); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.KeyEvent.staticClass, _getFlags7376); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxKeyCode7377; 
		public static int getMaxKeyCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.KeyEvent.staticClass, _getMaxKeyCode7377); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDeadChar7378; 
		public static int getDeadChar(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.KeyEvent.staticClass, _getDeadChar7378, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _changeTimeRepeat7379; 
		public static android.view.KeyEvent changeTimeRepeat(android.view.KeyEvent arg0, long arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.KeyEvent.staticClass, _changeTimeRepeat7379, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _changeTimeRepeat7380; 
		public static android.view.KeyEvent changeTimeRepeat(android.view.KeyEvent arg0, long arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.KeyEvent.staticClass, _changeTimeRepeat7380, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _changeAction7381; 
		public static android.view.KeyEvent changeAction(android.view.KeyEvent arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.KeyEvent.staticClass, _changeAction7381, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _changeFlags7382; 
		public static android.view.KeyEvent changeFlags(android.view.KeyEvent arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.KeyEvent.staticClass, _changeFlags7382, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSystem7383; 
		public virtual bool isSystem() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallBooleanMethod(this, _isSystem7383); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.KeyEvent.staticClass, _isSystem7383); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMetaState7384; 
		public virtual int getMetaState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallIntMethod(this, _getMetaState7384); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.KeyEvent.staticClass, _getMetaState7384); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isModifierKey7385; 
		public static bool isModifierKey(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.view.KeyEvent.staticClass, _isModifierKey7385, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAltPressed7386; 
		public virtual bool isAltPressed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallBooleanMethod(this, _isAltPressed7386); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.KeyEvent.staticClass, _isAltPressed7386); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isShiftPressed7387; 
		public virtual bool isShiftPressed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallBooleanMethod(this, _isShiftPressed7387); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.KeyEvent.staticClass, _isShiftPressed7387); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSymPressed7388; 
		public virtual bool isSymPressed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallBooleanMethod(this, _isSymPressed7388); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.KeyEvent.staticClass, _isSymPressed7388); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isCanceled7389; 
		public virtual bool isCanceled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallBooleanMethod(this, _isCanceled7389); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.KeyEvent.staticClass, _isCanceled7389); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startTracking7390; 
		public virtual void startTracking() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				@__env.CallVoidMethod(this, _startTracking7390); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.KeyEvent.staticClass, _startTracking7390); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isTracking7391; 
		public virtual bool isTracking() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallBooleanMethod(this, _isTracking7391); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.KeyEvent.staticClass, _isTracking7391); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLongPress7392; 
		public virtual bool isLongPress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallBooleanMethod(this, _isLongPress7392); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.KeyEvent.staticClass, _isLongPress7392); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyCode7393; 
		public virtual int getKeyCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallIntMethod(this, _getKeyCode7393); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.KeyEvent.staticClass, _getKeyCode7393); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCharacters7394; 
		public virtual java.lang.String getCharacters() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getCharacters7394)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.KeyEvent.staticClass, _getCharacters7394)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScanCode7395; 
		public virtual int getScanCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallIntMethod(this, _getScanCode7395); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.KeyEvent.staticClass, _getScanCode7395); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRepeatCount7396; 
		public virtual int getRepeatCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallIntMethod(this, _getRepeatCount7396); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.KeyEvent.staticClass, _getRepeatCount7396); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDownTime7397; 
		public virtual long getDownTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallLongMethod(this, _getDownTime7397); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.view.KeyEvent.staticClass, _getDownTime7397); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDeviceId7398; 
		public virtual int getDeviceId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallIntMethod(this, _getDeviceId7398); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.KeyEvent.staticClass, _getDeviceId7398); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayLabel7399; 
		public virtual char getDisplayLabel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallCharMethod(this, _getDisplayLabel7399); 
			else 
				return @__env.CallNonVirtualCharMethod(this, android.view.KeyEvent.staticClass, _getDisplayLabel7399); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUnicodeChar7400; 
		public virtual int getUnicodeChar(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallIntMethod(this, _getUnicodeChar7400, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.KeyEvent.staticClass, _getUnicodeChar7400, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUnicodeChar7401; 
		public virtual int getUnicodeChar() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallIntMethod(this, _getUnicodeChar7401); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.KeyEvent.staticClass, _getUnicodeChar7401); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyData7402; 
		public virtual bool getKeyData(android.view.KeyCharacterMap.KeyData arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallBooleanMethod(this, _getKeyData7402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.KeyEvent.staticClass, _getKeyData7402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMatch7403; 
		public virtual char getMatch(char[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallCharMethod(this, _getMatch7403, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, android.view.KeyEvent.staticClass, _getMatch7403, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMatch7404; 
		public virtual char getMatch(char[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallCharMethod(this, _getMatch7404, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, android.view.KeyEvent.staticClass, _getMatch7404, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPrintingKey7405; 
		public virtual bool isPrintingKey() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyEvent)) 
				return @__env.CallBooleanMethod(this, _isPrintingKey7405); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.KeyEvent.staticClass, _isPrintingKey7405); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyEvent7406; 
		public KeyEvent(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.KeyEvent.staticClass, _KeyEvent7406, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyEvent7407; 
		public KeyEvent(long arg0, long arg1, int arg2, int arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.KeyEvent.staticClass, _KeyEvent7407, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyEvent7408; 
		public KeyEvent(long arg0, long arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.KeyEvent.staticClass, _KeyEvent7408, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyEvent7409; 
		public KeyEvent(long arg0, long arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.KeyEvent.staticClass, _KeyEvent7409, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyEvent7410; 
		public KeyEvent(long arg0, long arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.KeyEvent.staticClass, _KeyEvent7410, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyEvent7411; 
		public KeyEvent(long arg0, java.lang.String arg1, int arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.KeyEvent.staticClass, _KeyEvent7411, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyEvent7412; 
		public KeyEvent(android.view.KeyEvent arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.KeyEvent.staticClass, _KeyEvent7412, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyEvent7413; 
		public KeyEvent(android.view.KeyEvent arg0, long arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.KeyEvent.staticClass, _KeyEvent7413, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR7414; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.KeyEvent.staticClass = @__class; 
			global::android.view.KeyEvent._dispatch7368 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "dispatch", "(Landroid/view/KeyEvent$Callback;)Z"); 
			global::android.view.KeyEvent._dispatch7369 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "dispatch", "(Landroid/view/KeyEvent$Callback;Landroid/view/KeyEvent$DispatcherState;Ljava/lang/Object;)Z"); 
			global::android.view.KeyEvent._toString7370 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.view.KeyEvent._getNumber7371 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getNumber", "()C"); 
			global::android.view.KeyEvent._getEventTime7372 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getEventTime", "()J"); 
			global::android.view.KeyEvent._writeToParcel7373 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.view.KeyEvent._describeContents7374 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "describeContents", "()I"); 
			global::android.view.KeyEvent._getAction7375 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getAction", "()I"); 
			global::android.view.KeyEvent._getFlags7376 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getFlags", "()I"); 
			global::android.view.KeyEvent._getMaxKeyCode7377 = @__env.GetStaticMethodID(global::android.view.KeyEvent.staticClass, "getMaxKeyCode", "()I"); 
			global::android.view.KeyEvent._getDeadChar7378 = @__env.GetStaticMethodID(global::android.view.KeyEvent.staticClass, "getDeadChar", "(II)I"); 
			global::android.view.KeyEvent._changeTimeRepeat7379 = @__env.GetStaticMethodID(global::android.view.KeyEvent.staticClass, "changeTimeRepeat", "(Landroid/view/KeyEvent;JII)Landroid/view/KeyEvent;"); 
			global::android.view.KeyEvent._changeTimeRepeat7380 = @__env.GetStaticMethodID(global::android.view.KeyEvent.staticClass, "changeTimeRepeat", "(Landroid/view/KeyEvent;JI)Landroid/view/KeyEvent;"); 
			global::android.view.KeyEvent._changeAction7381 = @__env.GetStaticMethodID(global::android.view.KeyEvent.staticClass, "changeAction", "(Landroid/view/KeyEvent;I)Landroid/view/KeyEvent;"); 
			global::android.view.KeyEvent._changeFlags7382 = @__env.GetStaticMethodID(global::android.view.KeyEvent.staticClass, "changeFlags", "(Landroid/view/KeyEvent;I)Landroid/view/KeyEvent;"); 
			global::android.view.KeyEvent._isSystem7383 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "isSystem", "()Z"); 
			global::android.view.KeyEvent._getMetaState7384 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getMetaState", "()I"); 
			global::android.view.KeyEvent._isModifierKey7385 = @__env.GetStaticMethodID(global::android.view.KeyEvent.staticClass, "isModifierKey", "(I)Z"); 
			global::android.view.KeyEvent._isAltPressed7386 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "isAltPressed", "()Z"); 
			global::android.view.KeyEvent._isShiftPressed7387 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "isShiftPressed", "()Z"); 
			global::android.view.KeyEvent._isSymPressed7388 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "isSymPressed", "()Z"); 
			global::android.view.KeyEvent._isCanceled7389 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "isCanceled", "()Z"); 
			global::android.view.KeyEvent._startTracking7390 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "startTracking", "()V"); 
			global::android.view.KeyEvent._isTracking7391 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "isTracking", "()Z"); 
			global::android.view.KeyEvent._isLongPress7392 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "isLongPress", "()Z"); 
			global::android.view.KeyEvent._getKeyCode7393 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getKeyCode", "()I"); 
			global::android.view.KeyEvent._getCharacters7394 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getCharacters", "()Ljava/lang/String;"); 
			global::android.view.KeyEvent._getScanCode7395 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getScanCode", "()I"); 
			global::android.view.KeyEvent._getRepeatCount7396 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getRepeatCount", "()I"); 
			global::android.view.KeyEvent._getDownTime7397 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getDownTime", "()J"); 
			global::android.view.KeyEvent._getDeviceId7398 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getDeviceId", "()I"); 
			global::android.view.KeyEvent._getDisplayLabel7399 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getDisplayLabel", "()C"); 
			global::android.view.KeyEvent._getUnicodeChar7400 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getUnicodeChar", "(I)I"); 
			global::android.view.KeyEvent._getUnicodeChar7401 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getUnicodeChar", "()I"); 
			global::android.view.KeyEvent._getKeyData7402 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getKeyData", "(Landroid/view/KeyCharacterMap$KeyData;)Z"); 
			global::android.view.KeyEvent._getMatch7403 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getMatch", "([CI)C"); 
			global::android.view.KeyEvent._getMatch7404 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getMatch", "([C)C"); 
			global::android.view.KeyEvent._isPrintingKey7405 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "isPrintingKey", "()Z"); 
			global::android.view.KeyEvent._KeyEvent7406 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "<init>", "(II)V"); 
			global::android.view.KeyEvent._KeyEvent7407 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "<init>", "(JJIII)V"); 
			global::android.view.KeyEvent._KeyEvent7408 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "<init>", "(JJIIII)V"); 
			global::android.view.KeyEvent._KeyEvent7409 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "<init>", "(JJIIIIII)V"); 
			global::android.view.KeyEvent._KeyEvent7410 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "<init>", "(JJIIIIIII)V"); 
			global::android.view.KeyEvent._KeyEvent7411 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "<init>", "(JLjava/lang/String;II)V"); 
			global::android.view.KeyEvent._KeyEvent7412 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "<init>", "(Landroid/view/KeyEvent;)V"); 
			global::android.view.KeyEvent._KeyEvent7413 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "<init>", "(Landroid/view/KeyEvent;JI)V"); 
		} 
	} 
} 
