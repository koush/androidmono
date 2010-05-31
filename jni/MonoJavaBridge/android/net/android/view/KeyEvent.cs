namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class KeyEvent : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static KeyEvent() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.KeyEvent), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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

		public partial class Callback_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __Callback.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __Callback : java.lang.Object, Callback
		{ 
			internal static global::java.lang.Class staticClass; 
			static __Callback() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.KeyEvent.__Callback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.KeyEvent.__Callback(@__env); 
				} 
			} 
			internal __Callback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onKeyDown7803; 
			 bool android.view.KeyEvent.Callback.onKeyDown(int arg0, android.view.KeyEvent arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.view.KeyEvent.__Callback._onKeyDown7803, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.KeyEvent.__Callback.staticClass, global::android.view.KeyEvent.__Callback._onKeyDown7803, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onKeyLongPress7804; 
			 bool android.view.KeyEvent.Callback.onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.view.KeyEvent.__Callback._onKeyLongPress7804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.KeyEvent.__Callback.staticClass, global::android.view.KeyEvent.__Callback._onKeyLongPress7804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onKeyUp7805; 
			 bool android.view.KeyEvent.Callback.onKeyUp(int arg0, android.view.KeyEvent arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.view.KeyEvent.__Callback._onKeyUp7805, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.KeyEvent.__Callback.staticClass, global::android.view.KeyEvent.__Callback._onKeyUp7805, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple7806; 
			 bool android.view.KeyEvent.Callback.onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.view.KeyEvent.__Callback._onKeyMultiple7806, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.KeyEvent.__Callback.staticClass, global::android.view.KeyEvent.__Callback._onKeyMultiple7806, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.KeyEvent.__Callback.staticClass = @__class; 
				global::android.view.KeyEvent.__Callback._onKeyDown7803 = @__env.GetMethodID(global::android.view.KeyEvent.__Callback.staticClass, "android.view.KeyEvent.Callback.onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
				global::android.view.KeyEvent.__Callback._onKeyLongPress7804 = @__env.GetMethodID(global::android.view.KeyEvent.__Callback.staticClass, "android.view.KeyEvent.Callback.onKeyLongPress", "(ILandroid/view/KeyEvent;)Z"); 
				global::android.view.KeyEvent.__Callback._onKeyUp7805 = @__env.GetMethodID(global::android.view.KeyEvent.__Callback.staticClass, "android.view.KeyEvent.Callback.onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
				global::android.view.KeyEvent.__Callback._onKeyMultiple7806 = @__env.GetMethodID(global::android.view.KeyEvent.__Callback.staticClass, "android.view.KeyEvent.Callback.onKeyMultiple", "(IILandroid/view/KeyEvent;)Z"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class DispatcherState : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static DispatcherState() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.KeyEvent.DispatcherState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _reset7807; 
			public virtual void reset() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.view.KeyEvent.DispatcherState._reset7807); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.KeyEvent.DispatcherState.staticClass, global::android.view.KeyEvent.DispatcherState._reset7807); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _reset7808; 
			public virtual void reset(java.lang.Object arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.view.KeyEvent.DispatcherState._reset7808, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.KeyEvent.DispatcherState.staticClass, global::android.view.KeyEvent.DispatcherState._reset7808, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _startTracking7809; 
			public virtual void startTracking(android.view.KeyEvent arg0, java.lang.Object arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.view.KeyEvent.DispatcherState._startTracking7809, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.KeyEvent.DispatcherState.staticClass, global::android.view.KeyEvent.DispatcherState._startTracking7809, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isTracking7810; 
			public virtual bool isTracking(android.view.KeyEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.view.KeyEvent.DispatcherState._isTracking7810, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.KeyEvent.DispatcherState.staticClass, global::android.view.KeyEvent.DispatcherState._isTracking7810, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _performedLongPress7811; 
			public virtual void performedLongPress(android.view.KeyEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.view.KeyEvent.DispatcherState._performedLongPress7811, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.KeyEvent.DispatcherState.staticClass, global::android.view.KeyEvent.DispatcherState._performedLongPress7811, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _handleUpEvent7812; 
			public virtual void handleUpEvent(android.view.KeyEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.view.KeyEvent.DispatcherState._handleUpEvent7812, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.KeyEvent.DispatcherState.staticClass, global::android.view.KeyEvent.DispatcherState._handleUpEvent7812, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _DispatcherState7813; 
			public DispatcherState()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.KeyEvent.DispatcherState.staticClass, global::android.view.KeyEvent.DispatcherState._DispatcherState7813, this); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.KeyEvent.DispatcherState.staticClass = @__class; 
				global::android.view.KeyEvent.DispatcherState._reset7807 = @__env.GetMethodID(global::android.view.KeyEvent.DispatcherState.staticClass, "reset", "()V"); 
				global::android.view.KeyEvent.DispatcherState._reset7808 = @__env.GetMethodID(global::android.view.KeyEvent.DispatcherState.staticClass, "reset", "(Ljava/lang/Object;)V"); 
				global::android.view.KeyEvent.DispatcherState._startTracking7809 = @__env.GetMethodID(global::android.view.KeyEvent.DispatcherState.staticClass, "startTracking", "(Landroid/view/KeyEvent;Ljava/lang/Object;)V"); 
				global::android.view.KeyEvent.DispatcherState._isTracking7810 = @__env.GetMethodID(global::android.view.KeyEvent.DispatcherState.staticClass, "isTracking", "(Landroid/view/KeyEvent;)Z"); 
				global::android.view.KeyEvent.DispatcherState._performedLongPress7811 = @__env.GetMethodID(global::android.view.KeyEvent.DispatcherState.staticClass, "performedLongPress", "(Landroid/view/KeyEvent;)V"); 
				global::android.view.KeyEvent.DispatcherState._handleUpEvent7812 = @__env.GetMethodID(global::android.view.KeyEvent.DispatcherState.staticClass, "handleUpEvent", "(Landroid/view/KeyEvent;)V"); 
				global::android.view.KeyEvent.DispatcherState._DispatcherState7813 = @__env.GetMethodID(global::android.view.KeyEvent.DispatcherState.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatch7814; 
		public virtual bool dispatch(android.view.KeyEvent.Callback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.KeyEvent._dispatch7814, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._dispatch7814, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatch7815; 
		public virtual bool dispatch(android.view.KeyEvent.Callback arg0, android.view.KeyEvent.DispatcherState arg1, java.lang.Object arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.KeyEvent._dispatch7815, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._dispatch7815, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString7816; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.KeyEvent._toString7816)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._toString7816)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumber7817; 
		public virtual char getNumber() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallCharMethod(this, global::android.view.KeyEvent._getNumber7817); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getNumber7817); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEventTime7818; 
		public virtual long getEventTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::android.view.KeyEvent._getEventTime7818); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getEventTime7818); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7819; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.KeyEvent._writeToParcel7819, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._writeToParcel7819, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7820; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.KeyEvent._describeContents7820); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._describeContents7820); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAction7821; 
		public virtual int getAction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.KeyEvent._getAction7821); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getAction7821); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFlags7822; 
		public virtual int getFlags() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.KeyEvent._getFlags7822); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getFlags7822); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxKeyCode7823; 
		public static int getMaxKeyCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getMaxKeyCode7823); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDeadChar7824; 
		public static int getDeadChar(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getDeadChar7824, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _changeTimeRepeat7825; 
		public static global::android.view.KeyEvent changeTimeRepeat(android.view.KeyEvent arg0, long arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._changeTimeRepeat7825, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _changeTimeRepeat7826; 
		public static global::android.view.KeyEvent changeTimeRepeat(android.view.KeyEvent arg0, long arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._changeTimeRepeat7826, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _changeAction7827; 
		public static global::android.view.KeyEvent changeAction(android.view.KeyEvent arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._changeAction7827, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _changeFlags7828; 
		public static global::android.view.KeyEvent changeFlags(android.view.KeyEvent arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._changeFlags7828, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSystem7829; 
		public virtual bool isSystem() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.KeyEvent._isSystem7829); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._isSystem7829); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMetaState7830; 
		public virtual int getMetaState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.KeyEvent._getMetaState7830); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getMetaState7830); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isModifierKey7831; 
		public static bool isModifierKey(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._isModifierKey7831, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAltPressed7832; 
		public virtual bool isAltPressed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.KeyEvent._isAltPressed7832); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._isAltPressed7832); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isShiftPressed7833; 
		public virtual bool isShiftPressed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.KeyEvent._isShiftPressed7833); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._isShiftPressed7833); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSymPressed7834; 
		public virtual bool isSymPressed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.KeyEvent._isSymPressed7834); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._isSymPressed7834); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isCanceled7835; 
		public virtual bool isCanceled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.KeyEvent._isCanceled7835); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._isCanceled7835); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startTracking7836; 
		public virtual void startTracking() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.KeyEvent._startTracking7836); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._startTracking7836); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isTracking7837; 
		public virtual bool isTracking() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.KeyEvent._isTracking7837); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._isTracking7837); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLongPress7838; 
		public virtual bool isLongPress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.KeyEvent._isLongPress7838); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._isLongPress7838); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyCode7839; 
		public virtual int getKeyCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.KeyEvent._getKeyCode7839); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getKeyCode7839); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCharacters7840; 
		public virtual global::java.lang.String getCharacters() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.KeyEvent._getCharacters7840)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getCharacters7840)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScanCode7841; 
		public virtual int getScanCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.KeyEvent._getScanCode7841); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getScanCode7841); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRepeatCount7842; 
		public virtual int getRepeatCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.KeyEvent._getRepeatCount7842); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getRepeatCount7842); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDownTime7843; 
		public virtual long getDownTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::android.view.KeyEvent._getDownTime7843); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getDownTime7843); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDeviceId7844; 
		public virtual int getDeviceId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.KeyEvent._getDeviceId7844); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getDeviceId7844); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayLabel7845; 
		public virtual char getDisplayLabel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallCharMethod(this, global::android.view.KeyEvent._getDisplayLabel7845); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getDisplayLabel7845); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUnicodeChar7846; 
		public virtual int getUnicodeChar(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.KeyEvent._getUnicodeChar7846, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getUnicodeChar7846, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUnicodeChar7847; 
		public virtual int getUnicodeChar() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.KeyEvent._getUnicodeChar7847); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getUnicodeChar7847); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyData7848; 
		public virtual bool getKeyData(android.view.KeyCharacterMap.KeyData arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.KeyEvent._getKeyData7848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getKeyData7848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMatch7849; 
		public virtual char getMatch(char[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallCharMethod(this, global::android.view.KeyEvent._getMatch7849, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getMatch7849, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMatch7850; 
		public virtual char getMatch(char[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallCharMethod(this, global::android.view.KeyEvent._getMatch7850, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._getMatch7850, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPrintingKey7851; 
		public virtual bool isPrintingKey() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.KeyEvent._isPrintingKey7851); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.KeyEvent.staticClass, global::android.view.KeyEvent._isPrintingKey7851); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyEvent7852; 
		public KeyEvent(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._KeyEvent7852, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyEvent7853; 
		public KeyEvent(long arg0, long arg1, int arg2, int arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._KeyEvent7853, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyEvent7854; 
		public KeyEvent(long arg0, long arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._KeyEvent7854, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyEvent7855; 
		public KeyEvent(long arg0, long arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._KeyEvent7855, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyEvent7856; 
		public KeyEvent(long arg0, long arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._KeyEvent7856, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyEvent7857; 
		public KeyEvent(long arg0, java.lang.String arg1, int arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._KeyEvent7857, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyEvent7858; 
		public KeyEvent(android.view.KeyEvent arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._KeyEvent7858, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _KeyEvent7859; 
		public KeyEvent(android.view.KeyEvent arg0, long arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.KeyEvent.staticClass, global::android.view.KeyEvent._KeyEvent7859, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR7860; 
		public static global::android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(global::android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.KeyEvent.staticClass = @__class; 
			global::android.view.KeyEvent._dispatch7814 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "dispatch", "(Landroid/view/KeyEvent$Callback;)Z"); 
			global::android.view.KeyEvent._dispatch7815 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "dispatch", "(Landroid/view/KeyEvent$Callback;Landroid/view/KeyEvent$DispatcherState;Ljava/lang/Object;)Z"); 
			global::android.view.KeyEvent._toString7816 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.view.KeyEvent._getNumber7817 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getNumber", "()C"); 
			global::android.view.KeyEvent._getEventTime7818 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getEventTime", "()J"); 
			global::android.view.KeyEvent._writeToParcel7819 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.view.KeyEvent._describeContents7820 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "describeContents", "()I"); 
			global::android.view.KeyEvent._getAction7821 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getAction", "()I"); 
			global::android.view.KeyEvent._getFlags7822 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getFlags", "()I"); 
			global::android.view.KeyEvent._getMaxKeyCode7823 = @__env.GetStaticMethodID(global::android.view.KeyEvent.staticClass, "getMaxKeyCode", "()I"); 
			global::android.view.KeyEvent._getDeadChar7824 = @__env.GetStaticMethodID(global::android.view.KeyEvent.staticClass, "getDeadChar", "(II)I"); 
			global::android.view.KeyEvent._changeTimeRepeat7825 = @__env.GetStaticMethodID(global::android.view.KeyEvent.staticClass, "changeTimeRepeat", "(Landroid/view/KeyEvent;JII)Landroid/view/KeyEvent;"); 
			global::android.view.KeyEvent._changeTimeRepeat7826 = @__env.GetStaticMethodID(global::android.view.KeyEvent.staticClass, "changeTimeRepeat", "(Landroid/view/KeyEvent;JI)Landroid/view/KeyEvent;"); 
			global::android.view.KeyEvent._changeAction7827 = @__env.GetStaticMethodID(global::android.view.KeyEvent.staticClass, "changeAction", "(Landroid/view/KeyEvent;I)Landroid/view/KeyEvent;"); 
			global::android.view.KeyEvent._changeFlags7828 = @__env.GetStaticMethodID(global::android.view.KeyEvent.staticClass, "changeFlags", "(Landroid/view/KeyEvent;I)Landroid/view/KeyEvent;"); 
			global::android.view.KeyEvent._isSystem7829 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "isSystem", "()Z"); 
			global::android.view.KeyEvent._getMetaState7830 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getMetaState", "()I"); 
			global::android.view.KeyEvent._isModifierKey7831 = @__env.GetStaticMethodID(global::android.view.KeyEvent.staticClass, "isModifierKey", "(I)Z"); 
			global::android.view.KeyEvent._isAltPressed7832 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "isAltPressed", "()Z"); 
			global::android.view.KeyEvent._isShiftPressed7833 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "isShiftPressed", "()Z"); 
			global::android.view.KeyEvent._isSymPressed7834 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "isSymPressed", "()Z"); 
			global::android.view.KeyEvent._isCanceled7835 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "isCanceled", "()Z"); 
			global::android.view.KeyEvent._startTracking7836 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "startTracking", "()V"); 
			global::android.view.KeyEvent._isTracking7837 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "isTracking", "()Z"); 
			global::android.view.KeyEvent._isLongPress7838 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "isLongPress", "()Z"); 
			global::android.view.KeyEvent._getKeyCode7839 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getKeyCode", "()I"); 
			global::android.view.KeyEvent._getCharacters7840 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getCharacters", "()Ljava/lang/String;"); 
			global::android.view.KeyEvent._getScanCode7841 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getScanCode", "()I"); 
			global::android.view.KeyEvent._getRepeatCount7842 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getRepeatCount", "()I"); 
			global::android.view.KeyEvent._getDownTime7843 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getDownTime", "()J"); 
			global::android.view.KeyEvent._getDeviceId7844 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getDeviceId", "()I"); 
			global::android.view.KeyEvent._getDisplayLabel7845 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getDisplayLabel", "()C"); 
			global::android.view.KeyEvent._getUnicodeChar7846 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getUnicodeChar", "(I)I"); 
			global::android.view.KeyEvent._getUnicodeChar7847 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getUnicodeChar", "()I"); 
			global::android.view.KeyEvent._getKeyData7848 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getKeyData", "(Landroid/view/KeyCharacterMap$KeyData;)Z"); 
			global::android.view.KeyEvent._getMatch7849 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getMatch", "([CI)C"); 
			global::android.view.KeyEvent._getMatch7850 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "getMatch", "([C)C"); 
			global::android.view.KeyEvent._isPrintingKey7851 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "isPrintingKey", "()Z"); 
			global::android.view.KeyEvent._KeyEvent7852 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "<init>", "(II)V"); 
			global::android.view.KeyEvent._KeyEvent7853 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "<init>", "(JJIII)V"); 
			global::android.view.KeyEvent._KeyEvent7854 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "<init>", "(JJIIII)V"); 
			global::android.view.KeyEvent._KeyEvent7855 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "<init>", "(JJIIIIII)V"); 
			global::android.view.KeyEvent._KeyEvent7856 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "<init>", "(JJIIIIIII)V"); 
			global::android.view.KeyEvent._KeyEvent7857 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "<init>", "(JLjava/lang/String;II)V"); 
			global::android.view.KeyEvent._KeyEvent7858 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "<init>", "(Landroid/view/KeyEvent;)V"); 
			global::android.view.KeyEvent._KeyEvent7859 = @__env.GetMethodID(global::android.view.KeyEvent.staticClass, "<init>", "(Landroid/view/KeyEvent;JI)V"); 
		} 
	} 
} 
