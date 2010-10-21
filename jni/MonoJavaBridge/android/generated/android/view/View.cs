namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class View : java.lang.Object, android.graphics.drawable.Drawable.Callback, android.view.KeyEvent.Callback, android.view.accessibility.AccessibilityEventSource
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static View()
		{
			InitJNI();
		}
		protected View(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class BaseSavedState : android.view.AbsSavedState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static BaseSavedState()
			{
				InitJNI();
			}
			protected BaseSavedState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _BaseSavedState14550;
			public BaseSavedState(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.BaseSavedState.staticClass, global::android.view.View.BaseSavedState._BaseSavedState14550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _BaseSavedState14551;
			public BaseSavedState(android.os.Parcelable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.BaseSavedState.staticClass, global::android.view.View.BaseSavedState._BaseSavedState14551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR14552;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.View.BaseSavedState.staticClass, _CREATOR14552)) as android.os.Parcelable_Creator;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.BaseSavedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$BaseSavedState"));
				global::android.view.View.BaseSavedState._BaseSavedState14550 = @__env.GetMethodIDNoThrow(global::android.view.View.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
				global::android.view.View.BaseSavedState._BaseSavedState14551 = @__env.GetMethodIDNoThrow(global::android.view.View.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V");
				global::android.view.View.BaseSavedState._CREATOR14552 = @__env.GetStaticFieldIDNoThrow(global::android.view.View.BaseSavedState.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class MeasureSpec : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static MeasureSpec()
			{
				InitJNI();
			}
			protected MeasureSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString14553;
			public static global::java.lang.String toString(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._toString14553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getSize14554;
			public static int getSize(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._getSize14554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getMode14555;
			public static int getMode(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._getMode14555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _makeMeasureSpec14556;
			public static int makeMeasureSpec(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._makeMeasureSpec14556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _MeasureSpec14557;
			public MeasureSpec()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._MeasureSpec14557);
				Init(@__env, handle);
			}
			public static int UNSPECIFIED
			{
				get
				{
					return 0;
				}
			}
			public static int EXACTLY
			{
				get
				{
					return 1073741824;
				}
			}
			public static int AT_MOST
			{
				get
				{
					return -2147483648;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.MeasureSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$MeasureSpec"));
				global::android.view.View.MeasureSpec._toString14553 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "toString", "(I)Ljava/lang/String;");
				global::android.view.View.MeasureSpec._getSize14554 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "getSize", "(I)I");
				global::android.view.View.MeasureSpec._getMode14555 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "getMode", "(I)I");
				global::android.view.View.MeasureSpec._makeMeasureSpec14556 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "makeMeasureSpec", "(II)I");
				global::android.view.View.MeasureSpec._MeasureSpec14557 = @__env.GetMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnClickListener_))]
		public interface OnClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onClick(android.view.View arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnClickListener))]
		public sealed partial class OnClickListener_ : java.lang.Object, OnClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnClickListener_()
			{
				InitJNI();
			}
			internal OnClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onClick14561;
			 void android.view.View.OnClickListener.onClick(android.view.View arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.View.OnClickListener_._onClick14561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.OnClickListener_.staticClass, global::android.view.View.OnClickListener_._onClick14561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnClickListener"));
				global::android.view.View.OnClickListener_._onClick14561 = @__env.GetMethodIDNoThrow(global::android.view.View.OnClickListener_.staticClass, "onClick", "(Landroid/view/View;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnCreateContextMenuListener_))]
		public interface OnCreateContextMenuListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnCreateContextMenuListener))]
		public sealed partial class OnCreateContextMenuListener_ : java.lang.Object, OnCreateContextMenuListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnCreateContextMenuListener_()
			{
				InitJNI();
			}
			internal OnCreateContextMenuListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onCreateContextMenu14562;
			 void android.view.View.OnCreateContextMenuListener.onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.View.OnCreateContextMenuListener_._onCreateContextMenu14562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.OnCreateContextMenuListener_.staticClass, global::android.view.View.OnCreateContextMenuListener_._onCreateContextMenu14562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnCreateContextMenuListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnCreateContextMenuListener"));
				global::android.view.View.OnCreateContextMenuListener_._onCreateContextMenu14562 = @__env.GetMethodIDNoThrow(global::android.view.View.OnCreateContextMenuListener_.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnFocusChangeListener_))]
		public interface OnFocusChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onFocusChange(android.view.View arg0, bool arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnFocusChangeListener))]
		public sealed partial class OnFocusChangeListener_ : java.lang.Object, OnFocusChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnFocusChangeListener_()
			{
				InitJNI();
			}
			internal OnFocusChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onFocusChange14563;
			 void android.view.View.OnFocusChangeListener.onFocusChange(android.view.View arg0, bool arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.View.OnFocusChangeListener_._onFocusChange14563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.OnFocusChangeListener_.staticClass, global::android.view.View.OnFocusChangeListener_._onFocusChange14563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnFocusChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnFocusChangeListener"));
				global::android.view.View.OnFocusChangeListener_._onFocusChange14563 = @__env.GetMethodIDNoThrow(global::android.view.View.OnFocusChangeListener_.staticClass, "onFocusChange", "(Landroid/view/View;Z)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnKeyListener_))]
		public interface OnKeyListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onKey(android.view.View arg0, int arg1, android.view.KeyEvent arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnKeyListener))]
		public sealed partial class OnKeyListener_ : java.lang.Object, OnKeyListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnKeyListener_()
			{
				InitJNI();
			}
			internal OnKeyListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onKey14564;
			 bool android.view.View.OnKeyListener.onKey(android.view.View arg0, int arg1, android.view.KeyEvent arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View.OnKeyListener_._onKey14564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.OnKeyListener_.staticClass, global::android.view.View.OnKeyListener_._onKey14564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnKeyListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnKeyListener"));
				global::android.view.View.OnKeyListener_._onKey14564 = @__env.GetMethodIDNoThrow(global::android.view.View.OnKeyListener_.staticClass, "onKey", "(Landroid/view/View;ILandroid/view/KeyEvent;)Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnLongClickListener_))]
		public interface OnLongClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onLongClick(android.view.View arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnLongClickListener))]
		public sealed partial class OnLongClickListener_ : java.lang.Object, OnLongClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnLongClickListener_()
			{
				InitJNI();
			}
			internal OnLongClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onLongClick14565;
			 bool android.view.View.OnLongClickListener.onLongClick(android.view.View arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View.OnLongClickListener_._onLongClick14565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.OnLongClickListener_.staticClass, global::android.view.View.OnLongClickListener_._onLongClick14565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnLongClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnLongClickListener"));
				global::android.view.View.OnLongClickListener_._onLongClick14565 = @__env.GetMethodIDNoThrow(global::android.view.View.OnLongClickListener_.staticClass, "onLongClick", "(Landroid/view/View;)Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnTouchListener_))]
		public interface OnTouchListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onTouch(android.view.View arg0, android.view.MotionEvent arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnTouchListener))]
		public sealed partial class OnTouchListener_ : java.lang.Object, OnTouchListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnTouchListener_()
			{
				InitJNI();
			}
			internal OnTouchListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onTouch14566;
			 bool android.view.View.OnTouchListener.onTouch(android.view.View arg0, android.view.MotionEvent arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View.OnTouchListener_._onTouch14566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.OnTouchListener_.staticClass, global::android.view.View.OnTouchListener_._onTouch14566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnTouchListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnTouchListener"));
				global::android.view.View.OnTouchListener_._onTouch14566 = @__env.GetMethodIDNoThrow(global::android.view.View.OnTouchListener_.staticClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
			}
		}
		public new global::android.content.res.Resources Resources
		{
			get
			{
				return getResources();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResources14567;
		public virtual global::android.content.res.Resources getResources() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getResources14567)) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getResources14567)) as android.content.res.Resources;
		}
		public new global::android.view.ViewParent Parent
		{
			get
			{
				return getParent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParent14568;
		public virtual global::android.view.ViewParent getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getParent14568)) as android.view.ViewParent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getParent14568)) as android.view.ViewParent;
		}
		public new int Id
		{
			get
			{
				return getId();
			}
			set
			{
				setId(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getId14569;
		public virtual int getId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getId14569);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getId14569);
		}
		public new global::android.content.Context Context
		{
			get
			{
				return getContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext14570;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getContext14570)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getContext14570)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _isOpaque14571;
		public virtual bool isOpaque() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isOpaque14571);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isOpaque14571);
		}
		public new global::android.os.Handler Handler
		{
			get
			{
				return getHandler();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHandler14572;
		public virtual global::android.os.Handler getHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getHandler14572)) as android.os.Handler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getHandler14572)) as android.os.Handler;
		}
		internal static global::MonoJavaBridge.MethodId _inflate14573;
		public static global::android.view.View inflate(android.content.Context arg0, int arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.View.staticClass, global::android.view.View._inflate14573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getTag14574;
		public virtual global::java.lang.Object getTag(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getTag14574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTag14574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		public new global::java.lang.Object Tag
		{
			get
			{
				return getTag();
			}
			set
			{
				setTag(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTag14575;
		public virtual global::java.lang.Object getTag() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getTag14575)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTag14575)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _invalidate14576;
		public virtual void invalidate(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._invalidate14576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._invalidate14576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invalidate14577;
		public virtual void invalidate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._invalidate14577);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._invalidate14577);
		}
		internal static global::MonoJavaBridge.MethodId _invalidate14578;
		public virtual void invalidate(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._invalidate14578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._invalidate14578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _layout14579;
		public virtual void layout(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._layout14579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._layout14579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged14580;
		protected virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onConfigurationChanged14580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onConfigurationChanged14580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled14581;
		public virtual bool isEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isEnabled14581);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isEnabled14581);
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled14582;
		public virtual void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setEnabled14582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setEnabled14582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new string ContentDescription
		{
			get
			{
				return getContentDescription().toString();
			}
			set
			{
				setContentDescription((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentDescription14583;
		public virtual global::java.lang.CharSequence getContentDescription() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getContentDescription14583)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getContentDescription14583)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setContentDescription14584;
		public virtual void setContentDescription(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setContentDescription14584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setContentDescription14584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setContentDescription(string arg0)
		{
			setContentDescription((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		public new global::android.view.animation.Animation Animation
		{
			get
			{
				return getAnimation();
			}
			set
			{
				setAnimation(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAnimation14585;
		public virtual global::android.view.animation.Animation getAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getAnimation14585)) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getAnimation14585)) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _draw14586;
		public virtual void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._draw14586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._draw14586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWidth14587;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getWidth14587);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getWidth14587);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeight14588;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getHeight14588);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getHeight14588);
		}
		internal static global::MonoJavaBridge.MethodId _post14589;
		public virtual bool post(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._post14589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._post14589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postDelayed14590;
		public virtual bool postDelayed(java.lang.Runnable arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._postDelayed14590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._postDelayed14590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeCallbacks14591;
		public virtual bool removeCallbacks(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._removeCallbacks14591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._removeCallbacks14591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState14592;
		protected virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onRestoreInstanceState14592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onRestoreInstanceState14592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState14593;
		protected virtual global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._onSaveInstanceState14593)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onSaveInstanceState14593)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _findViewById14594;
		public virtual global::android.view.View findViewById(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._findViewById14594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._findViewById14594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown14595;
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onKeyDown14595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onKeyDown14595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress14596;
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onKeyLongPress14596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onKeyLongPress14596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp14597;
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onKeyUp14597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onKeyUp14597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple14598;
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onKeyMultiple14598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onKeyMultiple14598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent14599;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onTouchEvent14599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onTouchEvent14599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent14600;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onTrackballEvent14600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onTrackballEvent14600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged14601;
		public virtual void onWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onWindowFocusChanged14601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onWindowFocusChanged14601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasFocus14602;
		public virtual bool hasFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._hasFocus14602);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._hasFocus14602);
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow14603;
		protected virtual void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onAttachedToWindow14603);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onAttachedToWindow14603);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow14604;
		protected virtual void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onDetachedFromWindow14604);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onDetachedFromWindow14604);
		}
		internal static global::MonoJavaBridge.MethodId _hasWindowFocus14605;
		public virtual bool hasWindowFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._hasWindowFocus14605);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._hasWindowFocus14605);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent14606;
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchKeyEvent14606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchKeyEvent14606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent14607;
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchTouchEvent14607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchTouchEvent14607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent14608;
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchTrackballEvent14608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchTrackballEvent14608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent14609;
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchPopulateAccessibilityEvent14609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchPopulateAccessibilityEvent14609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateContextMenu14610;
		protected virtual void onCreateContextMenu(android.view.ContextMenu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onCreateContextMenu14610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onCreateContextMenu14610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawable14611;
		public virtual void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setBackgroundDrawable14611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setBackgroundDrawable14611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _saveHierarchyState14612;
		public virtual void saveHierarchyState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._saveHierarchyState14612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._saveHierarchyState14612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _restoreHierarchyState14613;
		public virtual void restoreHierarchyState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._restoreHierarchyState14613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._restoreHierarchyState14613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _initializeFadingEdge14614;
		protected virtual void initializeFadingEdge(android.content.res.TypedArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._initializeFadingEdge14614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._initializeFadingEdge14614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int VerticalFadingEdgeLength
		{
			get
			{
				return getVerticalFadingEdgeLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVerticalFadingEdgeLength14615;
		public virtual int getVerticalFadingEdgeLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getVerticalFadingEdgeLength14615);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getVerticalFadingEdgeLength14615);
		}
		internal static global::MonoJavaBridge.MethodId _setFadingEdgeLength14616;
		public virtual void setFadingEdgeLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setFadingEdgeLength14616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setFadingEdgeLength14616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int HorizontalFadingEdgeLength
		{
			get
			{
				return getHorizontalFadingEdgeLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHorizontalFadingEdgeLength14617;
		public virtual int getHorizontalFadingEdgeLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getHorizontalFadingEdgeLength14617);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getHorizontalFadingEdgeLength14617);
		}
		public new int VerticalScrollbarWidth
		{
			get
			{
				return getVerticalScrollbarWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVerticalScrollbarWidth14618;
		public virtual int getVerticalScrollbarWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getVerticalScrollbarWidth14618);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getVerticalScrollbarWidth14618);
		}
		protected new int HorizontalScrollbarHeight
		{
			get
			{
				return getHorizontalScrollbarHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHorizontalScrollbarHeight14619;
		protected virtual int getHorizontalScrollbarHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getHorizontalScrollbarHeight14619);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getHorizontalScrollbarHeight14619);
		}
		internal static global::MonoJavaBridge.MethodId _initializeScrollbars14620;
		protected virtual void initializeScrollbars(android.content.res.TypedArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._initializeScrollbars14620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._initializeScrollbars14620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnFocusChangeListener14621;
		public virtual void setOnFocusChangeListener(android.view.View.OnFocusChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setOnFocusChangeListener14621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setOnFocusChangeListener14621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnFocusChangeListener14622;
		public virtual global::android.view.View.OnFocusChangeListener getOnFocusChangeListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.View.OnFocusChangeListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getOnFocusChangeListener14622)) as android.view.View.OnFocusChangeListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.View.OnFocusChangeListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getOnFocusChangeListener14622)) as android.view.View.OnFocusChangeListener;
		}
		internal static global::MonoJavaBridge.MethodId _setOnClickListener14623;
		public virtual void setOnClickListener(android.view.View.OnClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setOnClickListener14623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setOnClickListener14623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnLongClickListener14624;
		public virtual void setOnLongClickListener(android.view.View.OnLongClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setOnLongClickListener14624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setOnLongClickListener14624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnCreateContextMenuListener14625;
		public virtual void setOnCreateContextMenuListener(android.view.View.OnCreateContextMenuListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setOnCreateContextMenuListener14625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setOnCreateContextMenuListener14625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performClick14626;
		public virtual bool performClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._performClick14626);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._performClick14626);
		}
		internal static global::MonoJavaBridge.MethodId _performLongClick14627;
		public virtual bool performLongClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._performLongClick14627);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._performLongClick14627);
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenu14628;
		public virtual bool showContextMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._showContextMenu14628);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._showContextMenu14628);
		}
		internal static global::MonoJavaBridge.MethodId _setOnKeyListener14629;
		public virtual void setOnKeyListener(android.view.View.OnKeyListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setOnKeyListener14629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setOnKeyListener14629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnTouchListener14630;
		public virtual void setOnTouchListener(android.view.View.OnTouchListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setOnTouchListener14630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setOnTouchListener14630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestRectangleOnScreen14631;
		public virtual bool requestRectangleOnScreen(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._requestRectangleOnScreen14631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestRectangleOnScreen14631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestRectangleOnScreen14632;
		public virtual bool requestRectangleOnScreen(android.graphics.Rect arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._requestRectangleOnScreen14632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestRectangleOnScreen14632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearFocus14633;
		public virtual void clearFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._clearFocus14633);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._clearFocus14633);
		}
		internal static global::MonoJavaBridge.MethodId _hasFocusable14634;
		public virtual bool hasFocusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._hasFocusable14634);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._hasFocusable14634);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged14635;
		protected virtual void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onFocusChanged14635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onFocusChanged14635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sendAccessibilityEvent14636;
		public virtual void sendAccessibilityEvent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._sendAccessibilityEvent14636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._sendAccessibilityEvent14636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendAccessibilityEventUnchecked14637;
		public virtual void sendAccessibilityEventUnchecked(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._sendAccessibilityEventUnchecked14637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._sendAccessibilityEventUnchecked14637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFocused14638;
		public virtual bool isFocused() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isFocused14638);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isFocused14638);
		}
		internal static global::MonoJavaBridge.MethodId _findFocus14639;
		public virtual global::android.view.View findFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._findFocus14639)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._findFocus14639)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setScrollContainer14640;
		public virtual void setScrollContainer(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setScrollContainer14640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setScrollContainer14640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DrawingCacheQuality
		{
			get
			{
				return getDrawingCacheQuality();
			}
			set
			{
				setDrawingCacheQuality(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingCacheQuality14641;
		public virtual int getDrawingCacheQuality() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getDrawingCacheQuality14641);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawingCacheQuality14641);
		}
		internal static global::MonoJavaBridge.MethodId _setDrawingCacheQuality14642;
		public virtual void setDrawingCacheQuality(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setDrawingCacheQuality14642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setDrawingCacheQuality14642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool KeepScreenOn
		{
			get
			{
				return getKeepScreenOn();
			}
			set
			{
				setKeepScreenOn(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeepScreenOn14643;
		public virtual bool getKeepScreenOn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._getKeepScreenOn14643);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getKeepScreenOn14643);
		}
		internal static global::MonoJavaBridge.MethodId _setKeepScreenOn14644;
		public virtual void setKeepScreenOn(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setKeepScreenOn14644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setKeepScreenOn14644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NextFocusLeftId
		{
			get
			{
				return getNextFocusLeftId();
			}
			set
			{
				setNextFocusLeftId(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextFocusLeftId14645;
		public virtual int getNextFocusLeftId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getNextFocusLeftId14645);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getNextFocusLeftId14645);
		}
		internal static global::MonoJavaBridge.MethodId _setNextFocusLeftId14646;
		public virtual void setNextFocusLeftId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setNextFocusLeftId14646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setNextFocusLeftId14646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NextFocusRightId
		{
			get
			{
				return getNextFocusRightId();
			}
			set
			{
				setNextFocusRightId(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextFocusRightId14647;
		public virtual int getNextFocusRightId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getNextFocusRightId14647);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getNextFocusRightId14647);
		}
		internal static global::MonoJavaBridge.MethodId _setNextFocusRightId14648;
		public virtual void setNextFocusRightId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setNextFocusRightId14648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setNextFocusRightId14648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NextFocusUpId
		{
			get
			{
				return getNextFocusUpId();
			}
			set
			{
				setNextFocusUpId(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextFocusUpId14649;
		public virtual int getNextFocusUpId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getNextFocusUpId14649);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getNextFocusUpId14649);
		}
		internal static global::MonoJavaBridge.MethodId _setNextFocusUpId14650;
		public virtual void setNextFocusUpId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setNextFocusUpId14650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setNextFocusUpId14650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NextFocusDownId
		{
			get
			{
				return getNextFocusDownId();
			}
			set
			{
				setNextFocusDownId(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextFocusDownId14651;
		public virtual int getNextFocusDownId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getNextFocusDownId14651);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getNextFocusDownId14651);
		}
		internal static global::MonoJavaBridge.MethodId _setNextFocusDownId14652;
		public virtual void setNextFocusDownId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setNextFocusDownId14652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setNextFocusDownId14652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isShown14653;
		public virtual bool isShown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isShown14653);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isShown14653);
		}
		internal static global::MonoJavaBridge.MethodId _fitSystemWindows14654;
		protected virtual bool fitSystemWindows(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._fitSystemWindows14654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._fitSystemWindows14654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Visibility
		{
			get
			{
				return getVisibility();
			}
			set
			{
				setVisibility(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVisibility14655;
		public virtual int getVisibility() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getVisibility14655);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getVisibility14655);
		}
		internal static global::MonoJavaBridge.MethodId _setVisibility14656;
		public virtual void setVisibility(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setVisibility14656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setVisibility14656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFocusable14657;
		public virtual void setFocusable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setFocusable14657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setFocusable14657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFocusableInTouchMode14658;
		public virtual void setFocusableInTouchMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setFocusableInTouchMode14658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setFocusableInTouchMode14658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSoundEffectsEnabled14659;
		public virtual void setSoundEffectsEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setSoundEffectsEnabled14659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setSoundEffectsEnabled14659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSoundEffectsEnabled14660;
		public virtual bool isSoundEffectsEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isSoundEffectsEnabled14660);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isSoundEffectsEnabled14660);
		}
		internal static global::MonoJavaBridge.MethodId _setHapticFeedbackEnabled14661;
		public virtual void setHapticFeedbackEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setHapticFeedbackEnabled14661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setHapticFeedbackEnabled14661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isHapticFeedbackEnabled14662;
		public virtual bool isHapticFeedbackEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isHapticFeedbackEnabled14662);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isHapticFeedbackEnabled14662);
		}
		internal static global::MonoJavaBridge.MethodId _setWillNotDraw14663;
		public virtual void setWillNotDraw(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setWillNotDraw14663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setWillNotDraw14663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _willNotDraw14664;
		public virtual bool willNotDraw() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._willNotDraw14664);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._willNotDraw14664);
		}
		internal static global::MonoJavaBridge.MethodId _setWillNotCacheDrawing14665;
		public virtual void setWillNotCacheDrawing(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setWillNotCacheDrawing14665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setWillNotCacheDrawing14665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _willNotCacheDrawing14666;
		public virtual bool willNotCacheDrawing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._willNotCacheDrawing14666);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._willNotCacheDrawing14666);
		}
		internal static global::MonoJavaBridge.MethodId _isClickable14667;
		public virtual bool isClickable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isClickable14667);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isClickable14667);
		}
		internal static global::MonoJavaBridge.MethodId _setClickable14668;
		public virtual void setClickable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setClickable14668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setClickable14668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLongClickable14669;
		public virtual bool isLongClickable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isLongClickable14669);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isLongClickable14669);
		}
		internal static global::MonoJavaBridge.MethodId _setLongClickable14670;
		public virtual void setLongClickable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setLongClickable14670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setLongClickable14670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPressed14671;
		public virtual void setPressed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setPressed14671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setPressed14671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetPressed14672;
		protected virtual void dispatchSetPressed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchSetPressed14672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchSetPressed14672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPressed14673;
		public virtual bool isPressed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isPressed14673);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isPressed14673);
		}
		internal static global::MonoJavaBridge.MethodId _isSaveEnabled14674;
		public virtual bool isSaveEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isSaveEnabled14674);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isSaveEnabled14674);
		}
		internal static global::MonoJavaBridge.MethodId _setSaveEnabled14675;
		public virtual void setSaveEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setSaveEnabled14675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setSaveEnabled14675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFocusable14676;
		public virtual bool isFocusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isFocusable14676);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isFocusable14676);
		}
		internal static global::MonoJavaBridge.MethodId _isFocusableInTouchMode14677;
		public virtual bool isFocusableInTouchMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isFocusableInTouchMode14677);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isFocusableInTouchMode14677);
		}
		internal static global::MonoJavaBridge.MethodId _focusSearch14678;
		public virtual global::android.view.View focusSearch(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._focusSearch14678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._focusSearch14678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchUnhandledMove14679;
		public virtual bool dispatchUnhandledMove(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchUnhandledMove14679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchUnhandledMove14679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFocusables14680;
		public virtual global::java.util.ArrayList getFocusables(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getFocusables14680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getFocusables14680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _addFocusables14681;
		public virtual void addFocusables(java.util.ArrayList arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._addFocusables14681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._addFocusables14681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFocusables14682;
		public virtual void addFocusables(java.util.ArrayList arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._addFocusables14682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._addFocusables14682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.util.ArrayList Touchables
		{
			get
			{
				return getTouchables();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTouchables14683;
		public virtual global::java.util.ArrayList getTouchables() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getTouchables14683)) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTouchables14683)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _addTouchables14684;
		public virtual void addTouchables(java.util.ArrayList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._addTouchables14684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._addTouchables14684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus14685;
		public virtual bool requestFocus(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._requestFocus14685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestFocus14685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus14686;
		public virtual bool requestFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._requestFocus14686);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestFocus14686);
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus14687;
		public virtual bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._requestFocus14687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestFocus14687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocusFromTouch14688;
		public virtual bool requestFocusFromTouch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._requestFocusFromTouch14688);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestFocusFromTouch14688);
		}
		internal static global::MonoJavaBridge.MethodId _onStartTemporaryDetach14689;
		public virtual void onStartTemporaryDetach() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onStartTemporaryDetach14689);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onStartTemporaryDetach14689);
		}
		internal static global::MonoJavaBridge.MethodId _onFinishTemporaryDetach14690;
		public virtual void onFinishTemporaryDetach() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onFinishTemporaryDetach14690);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onFinishTemporaryDetach14690);
		}
		public new global::android.view.KeyEvent.DispatcherState KeyDispatcherState
		{
			get
			{
				return getKeyDispatcherState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeyDispatcherState14691;
		public virtual global::android.view.KeyEvent.DispatcherState getKeyDispatcherState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getKeyDispatcherState14691)) as android.view.KeyEvent.DispatcherState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getKeyDispatcherState14691)) as android.view.KeyEvent.DispatcherState;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEventPreIme14692;
		public virtual bool dispatchKeyEventPreIme(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchKeyEventPreIme14692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchKeyEventPreIme14692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyShortcutEvent14693;
		public virtual bool dispatchKeyShortcutEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchKeyShortcutEvent14693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchKeyShortcutEvent14693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowFocusChanged14694;
		public virtual void dispatchWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchWindowFocusChanged14694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchWindowFocusChanged14694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchVisibilityChanged14695;
		protected virtual void dispatchVisibilityChanged(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchVisibilityChanged14695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchVisibilityChanged14695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onVisibilityChanged14696;
		protected virtual void onVisibilityChanged(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onVisibilityChanged14696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onVisibilityChanged14696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDisplayHint14697;
		public virtual void dispatchDisplayHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchDisplayHint14697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchDisplayHint14697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDisplayHint14698;
		protected virtual void onDisplayHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onDisplayHint14698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onDisplayHint14698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowVisibilityChanged14699;
		public virtual void dispatchWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchWindowVisibilityChanged14699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchWindowVisibilityChanged14699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowVisibilityChanged14700;
		protected virtual void onWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onWindowVisibilityChanged14700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onWindowVisibilityChanged14700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int WindowVisibility
		{
			get
			{
				return getWindowVisibility();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindowVisibility14701;
		public virtual int getWindowVisibility() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getWindowVisibility14701);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getWindowVisibility14701);
		}
		internal static global::MonoJavaBridge.MethodId _getWindowVisibleDisplayFrame14702;
		public virtual void getWindowVisibleDisplayFrame(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._getWindowVisibleDisplayFrame14702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getWindowVisibleDisplayFrame14702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchConfigurationChanged14703;
		public virtual void dispatchConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchConfigurationChanged14703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchConfigurationChanged14703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInTouchMode14704;
		public virtual bool isInTouchMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isInTouchMode14704);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isInTouchMode14704);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyPreIme14705;
		public virtual bool onKeyPreIme(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onKeyPreIme14705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onKeyPreIme14705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyShortcut14706;
		public virtual bool onKeyShortcut(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onKeyShortcut14706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onKeyShortcut14706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCheckIsTextEditor14707;
		public virtual bool onCheckIsTextEditor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onCheckIsTextEditor14707);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onCheckIsTextEditor14707);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputConnection14708;
		public virtual global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._onCreateInputConnection14708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onCreateInputConnection14708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
		}
		internal static global::MonoJavaBridge.MethodId _checkInputConnectionProxy14709;
		public virtual bool checkInputConnectionProxy(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._checkInputConnectionProxy14709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._checkInputConnectionProxy14709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createContextMenu14710;
		public virtual void createContextMenu(android.view.ContextMenu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._createContextMenu14710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._createContextMenu14710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new global::android.view.ContextMenu_ContextMenuInfo ContextMenuInfo
		{
			get
			{
				return getContextMenuInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContextMenuInfo14711;
		protected virtual global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getContextMenuInfo14711)) as android.view.ContextMenu_ContextMenuInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getContextMenuInfo14711)) as android.view.ContextMenu_ContextMenuInfo;
		}
		internal static global::MonoJavaBridge.MethodId _cancelLongPress14712;
		public virtual void cancelLongPress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._cancelLongPress14712);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._cancelLongPress14712);
		}
		internal static global::MonoJavaBridge.MethodId _setTouchDelegate14713;
		public virtual void setTouchDelegate(android.view.TouchDelegate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setTouchDelegate14713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setTouchDelegate14713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.TouchDelegate TouchDelegate
		{
			get
			{
				return getTouchDelegate();
			}
			set
			{
				setTouchDelegate(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTouchDelegate14714;
		public virtual global::android.view.TouchDelegate getTouchDelegate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getTouchDelegate14714)) as android.view.TouchDelegate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTouchDelegate14714)) as android.view.TouchDelegate;
		}
		internal static global::MonoJavaBridge.MethodId _bringToFront14715;
		public virtual void bringToFront() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._bringToFront14715);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._bringToFront14715);
		}
		internal static global::MonoJavaBridge.MethodId _onScrollChanged14716;
		protected virtual void onScrollChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onScrollChanged14716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onScrollChanged14716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged14717;
		protected virtual void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onSizeChanged14717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onSizeChanged14717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw14718;
		protected virtual void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchDraw14718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchDraw14718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ScrollX
		{
			get
			{
				return getScrollX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollX14719;
		public virtual int getScrollX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getScrollX14719);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getScrollX14719);
		}
		public new int ScrollY
		{
			get
			{
				return getScrollY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollY14720;
		public virtual int getScrollY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getScrollY14720);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getScrollY14720);
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingRect14721;
		public virtual void getDrawingRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._getDrawingRect14721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawingRect14721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MeasuredWidth
		{
			get
			{
				return getMeasuredWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMeasuredWidth14722;
		public virtual int getMeasuredWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getMeasuredWidth14722);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getMeasuredWidth14722);
		}
		public new int MeasuredHeight
		{
			get
			{
				return getMeasuredHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMeasuredHeight14723;
		public virtual int getMeasuredHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getMeasuredHeight14723);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getMeasuredHeight14723);
		}
		public new int Top
		{
			get
			{
				return getTop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTop14724;
		public virtual int getTop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getTop14724);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTop14724);
		}
		public new int Bottom
		{
			get
			{
				return getBottom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottom14725;
		public virtual int getBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getBottom14725);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getBottom14725);
		}
		public new int Left
		{
			get
			{
				return getLeft();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeft14726;
		public virtual int getLeft() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getLeft14726);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLeft14726);
		}
		public new int Right
		{
			get
			{
				return getRight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRight14727;
		public virtual int getRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getRight14727);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getRight14727);
		}
		internal static global::MonoJavaBridge.MethodId _getHitRect14728;
		public virtual void getHitRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._getHitRect14728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getHitRect14728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFocusedRect14729;
		public virtual void getFocusedRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._getFocusedRect14729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getFocusedRect14729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalVisibleRect14730;
		public virtual bool getGlobalVisibleRect(android.graphics.Rect arg0, android.graphics.Point arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._getGlobalVisibleRect14730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getGlobalVisibleRect14730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalVisibleRect14731;
		public virtual bool getGlobalVisibleRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._getGlobalVisibleRect14731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getGlobalVisibleRect14731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLocalVisibleRect14732;
		public virtual bool getLocalVisibleRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._getLocalVisibleRect14732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLocalVisibleRect14732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offsetTopAndBottom14733;
		public virtual void offsetTopAndBottom(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._offsetTopAndBottom14733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._offsetTopAndBottom14733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offsetLeftAndRight14734;
		public virtual void offsetLeftAndRight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._offsetLeftAndRight14734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._offsetLeftAndRight14734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.ViewGroup.LayoutParams LayoutParams
		{
			get
			{
				return getLayoutParams();
			}
			set
			{
				setLayoutParams(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutParams14735;
		public virtual global::android.view.ViewGroup.LayoutParams getLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getLayoutParams14735)) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLayoutParams14735)) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutParams14736;
		public virtual void setLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setLayoutParams14736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setLayoutParams14736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scrollTo14737;
		public virtual void scrollTo(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._scrollTo14737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._scrollTo14737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scrollBy14738;
		public virtual void scrollBy(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._scrollBy14738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._scrollBy14738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _awakenScrollBars14739;
		protected virtual bool awakenScrollBars(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._awakenScrollBars14739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._awakenScrollBars14739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _awakenScrollBars14740;
		protected virtual bool awakenScrollBars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._awakenScrollBars14740);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._awakenScrollBars14740);
		}
		internal static global::MonoJavaBridge.MethodId _awakenScrollBars14741;
		protected virtual bool awakenScrollBars(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._awakenScrollBars14741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._awakenScrollBars14741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidate14742;
		public virtual void postInvalidate(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._postInvalidate14742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._postInvalidate14742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidate14743;
		public virtual void postInvalidate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._postInvalidate14743);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._postInvalidate14743);
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidateDelayed14744;
		public virtual void postInvalidateDelayed(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._postInvalidateDelayed14744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._postInvalidateDelayed14744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidateDelayed14745;
		public virtual void postInvalidateDelayed(long arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._postInvalidateDelayed14745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._postInvalidateDelayed14745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll14746;
		public virtual void computeScroll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._computeScroll14746);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeScroll14746);
		}
		internal static global::MonoJavaBridge.MethodId _isHorizontalFadingEdgeEnabled14747;
		public virtual bool isHorizontalFadingEdgeEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isHorizontalFadingEdgeEnabled14747);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isHorizontalFadingEdgeEnabled14747);
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalFadingEdgeEnabled14748;
		public virtual void setHorizontalFadingEdgeEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setHorizontalFadingEdgeEnabled14748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setHorizontalFadingEdgeEnabled14748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isVerticalFadingEdgeEnabled14749;
		public virtual bool isVerticalFadingEdgeEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isVerticalFadingEdgeEnabled14749);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isVerticalFadingEdgeEnabled14749);
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalFadingEdgeEnabled14750;
		public virtual void setVerticalFadingEdgeEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setVerticalFadingEdgeEnabled14750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setVerticalFadingEdgeEnabled14750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new float TopFadingEdgeStrength
		{
			get
			{
				return getTopFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTopFadingEdgeStrength14751;
		protected virtual float getTopFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.View._getTopFadingEdgeStrength14751);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTopFadingEdgeStrength14751);
		}
		protected new float BottomFadingEdgeStrength
		{
			get
			{
				return getBottomFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottomFadingEdgeStrength14752;
		protected virtual float getBottomFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.View._getBottomFadingEdgeStrength14752);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getBottomFadingEdgeStrength14752);
		}
		protected new float LeftFadingEdgeStrength
		{
			get
			{
				return getLeftFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeftFadingEdgeStrength14753;
		protected virtual float getLeftFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.View._getLeftFadingEdgeStrength14753);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLeftFadingEdgeStrength14753);
		}
		protected new float RightFadingEdgeStrength
		{
			get
			{
				return getRightFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRightFadingEdgeStrength14754;
		protected virtual float getRightFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.View._getRightFadingEdgeStrength14754);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getRightFadingEdgeStrength14754);
		}
		internal static global::MonoJavaBridge.MethodId _isHorizontalScrollBarEnabled14755;
		public virtual bool isHorizontalScrollBarEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isHorizontalScrollBarEnabled14755);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isHorizontalScrollBarEnabled14755);
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalScrollBarEnabled14756;
		public virtual void setHorizontalScrollBarEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setHorizontalScrollBarEnabled14756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setHorizontalScrollBarEnabled14756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isVerticalScrollBarEnabled14757;
		public virtual bool isVerticalScrollBarEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isVerticalScrollBarEnabled14757);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isVerticalScrollBarEnabled14757);
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalScrollBarEnabled14758;
		public virtual void setVerticalScrollBarEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setVerticalScrollBarEnabled14758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setVerticalScrollBarEnabled14758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setScrollbarFadingEnabled14759;
		public virtual void setScrollbarFadingEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setScrollbarFadingEnabled14759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setScrollbarFadingEnabled14759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isScrollbarFadingEnabled14760;
		public virtual bool isScrollbarFadingEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isScrollbarFadingEnabled14760);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isScrollbarFadingEnabled14760);
		}
		internal static global::MonoJavaBridge.MethodId _setScrollBarStyle14761;
		public virtual void setScrollBarStyle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setScrollBarStyle14761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setScrollBarStyle14761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ScrollBarStyle
		{
			get
			{
				return getScrollBarStyle();
			}
			set
			{
				setScrollBarStyle(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollBarStyle14762;
		public virtual int getScrollBarStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getScrollBarStyle14762);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getScrollBarStyle14762);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange14763;
		protected virtual int computeHorizontalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._computeHorizontalScrollRange14763);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeHorizontalScrollRange14763);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollOffset14764;
		protected virtual int computeHorizontalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._computeHorizontalScrollOffset14764);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeHorizontalScrollOffset14764);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollExtent14765;
		protected virtual int computeHorizontalScrollExtent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._computeHorizontalScrollExtent14765);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeHorizontalScrollExtent14765);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange14766;
		protected virtual int computeVerticalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._computeVerticalScrollRange14766);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeVerticalScrollRange14766);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollOffset14767;
		protected virtual int computeVerticalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._computeVerticalScrollOffset14767);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeVerticalScrollOffset14767);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent14768;
		protected virtual int computeVerticalScrollExtent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._computeVerticalScrollExtent14768);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeVerticalScrollExtent14768);
		}
		internal static global::MonoJavaBridge.MethodId _onDrawScrollBars14769;
		protected virtual void onDrawScrollBars(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onDrawScrollBars14769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onDrawScrollBars14769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDraw14770;
		protected virtual void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onDraw14770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onDraw14770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new int WindowAttachCount
		{
			get
			{
				return getWindowAttachCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindowAttachCount14771;
		protected virtual int getWindowAttachCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getWindowAttachCount14771);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getWindowAttachCount14771);
		}
		public new global::android.os.IBinder WindowToken
		{
			get
			{
				return getWindowToken();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindowToken14772;
		public virtual global::android.os.IBinder getWindowToken() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getWindowToken14772)) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getWindowToken14772)) as android.os.IBinder;
		}
		public new global::android.os.IBinder ApplicationWindowToken
		{
			get
			{
				return getApplicationWindowToken();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationWindowToken14773;
		public virtual global::android.os.IBinder getApplicationWindowToken() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getApplicationWindowToken14773)) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getApplicationWindowToken14773)) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSaveInstanceState14774;
		protected virtual void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchSaveInstanceState14774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchSaveInstanceState14774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchRestoreInstanceState14775;
		protected virtual void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchRestoreInstanceState14775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchRestoreInstanceState14775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long DrawingTime
		{
			get
			{
				return getDrawingTime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingTime14776;
		public virtual long getDrawingTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.View._getDrawingTime14776);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawingTime14776);
		}
		internal static global::MonoJavaBridge.MethodId _setDuplicateParentStateEnabled14777;
		public virtual void setDuplicateParentStateEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setDuplicateParentStateEnabled14777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setDuplicateParentStateEnabled14777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDuplicateParentStateEnabled14778;
		public virtual bool isDuplicateParentStateEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isDuplicateParentStateEnabled14778);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isDuplicateParentStateEnabled14778);
		}
		internal static global::MonoJavaBridge.MethodId _setDrawingCacheEnabled14779;
		public virtual void setDrawingCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setDrawingCacheEnabled14779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setDrawingCacheEnabled14779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDrawingCacheEnabled14780;
		public virtual bool isDrawingCacheEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isDrawingCacheEnabled14780);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isDrawingCacheEnabled14780);
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingCache14781;
		public virtual global::android.graphics.Bitmap getDrawingCache(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getDrawingCache14781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawingCache14781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
		}
		public new global::android.graphics.Bitmap DrawingCache
		{
			get
			{
				return getDrawingCache();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingCache14782;
		public virtual global::android.graphics.Bitmap getDrawingCache() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getDrawingCache14782)) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawingCache14782)) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _destroyDrawingCache14783;
		public virtual void destroyDrawingCache() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._destroyDrawingCache14783);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._destroyDrawingCache14783);
		}
		internal static global::MonoJavaBridge.MethodId _setDrawingCacheBackgroundColor14784;
		public virtual void setDrawingCacheBackgroundColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setDrawingCacheBackgroundColor14784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setDrawingCacheBackgroundColor14784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DrawingCacheBackgroundColor
		{
			get
			{
				return getDrawingCacheBackgroundColor();
			}
			set
			{
				setDrawingCacheBackgroundColor(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingCacheBackgroundColor14785;
		public virtual int getDrawingCacheBackgroundColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getDrawingCacheBackgroundColor14785);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawingCacheBackgroundColor14785);
		}
		internal static global::MonoJavaBridge.MethodId _buildDrawingCache14786;
		public virtual void buildDrawingCache() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._buildDrawingCache14786);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._buildDrawingCache14786);
		}
		internal static global::MonoJavaBridge.MethodId _buildDrawingCache14787;
		public virtual void buildDrawingCache(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._buildDrawingCache14787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._buildDrawingCache14787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInEditMode14788;
		public virtual bool isInEditMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isInEditMode14788);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isInEditMode14788);
		}
		internal static global::MonoJavaBridge.MethodId _isPaddingOffsetRequired14789;
		protected virtual bool isPaddingOffsetRequired() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isPaddingOffsetRequired14789);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isPaddingOffsetRequired14789);
		}
		protected new int LeftPaddingOffset
		{
			get
			{
				return getLeftPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeftPaddingOffset14790;
		protected virtual int getLeftPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getLeftPaddingOffset14790);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLeftPaddingOffset14790);
		}
		protected new int RightPaddingOffset
		{
			get
			{
				return getRightPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRightPaddingOffset14791;
		protected virtual int getRightPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getRightPaddingOffset14791);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getRightPaddingOffset14791);
		}
		protected new int TopPaddingOffset
		{
			get
			{
				return getTopPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTopPaddingOffset14792;
		protected virtual int getTopPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getTopPaddingOffset14792);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTopPaddingOffset14792);
		}
		protected new int BottomPaddingOffset
		{
			get
			{
				return getBottomPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPaddingOffset14793;
		protected virtual int getBottomPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getBottomPaddingOffset14793);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getBottomPaddingOffset14793);
		}
		public new int SolidColor
		{
			get
			{
				return getSolidColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSolidColor14794;
		public virtual int getSolidColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getSolidColor14794);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getSolidColor14794);
		}
		internal static global::MonoJavaBridge.MethodId _isLayoutRequested14795;
		public virtual bool isLayoutRequested() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isLayoutRequested14795);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isLayoutRequested14795);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout14796;
		protected virtual void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onLayout14796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onLayout14796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate14797;
		protected virtual void onFinishInflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onFinishInflate14797);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onFinishInflate14797);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable14798;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._invalidateDrawable14798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._invalidateDrawable14798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleDrawable14799;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._scheduleDrawable14799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._scheduleDrawable14799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable14800;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._unscheduleDrawable14800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._unscheduleDrawable14800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable14801;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._unscheduleDrawable14801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._unscheduleDrawable14801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable14802;
		protected virtual bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._verifyDrawable14802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._verifyDrawable14802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged14803;
		protected virtual void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._drawableStateChanged14803);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._drawableStateChanged14803);
		}
		internal static global::MonoJavaBridge.MethodId _refreshDrawableState14804;
		public virtual void refreshDrawableState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._refreshDrawableState14804);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._refreshDrawableState14804);
		}
		public new int[] DrawableState
		{
			get
			{
				return getDrawableState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawableState14805;
		public virtual int[] getDrawableState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getDrawableState14805)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawableState14805)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState14806;
		protected virtual int[] onCreateDrawableState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._onCreateDrawableState14806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onCreateDrawableState14806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _mergeDrawableStates14807;
		protected static int[] mergeDrawableStates(int[] arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.view.View.staticClass, global::android.view.View._mergeDrawableStates14807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundColor14808;
		public virtual void setBackgroundColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setBackgroundColor14808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setBackgroundColor14808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundResource14809;
		public virtual void setBackgroundResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setBackgroundResource14809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setBackgroundResource14809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable Background
		{
			get
			{
				return getBackground();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBackground14810;
		public virtual global::android.graphics.drawable.Drawable getBackground() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getBackground14810)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getBackground14810)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setPadding14811;
		public virtual void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setPadding14811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setPadding14811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new int PaddingTop
		{
			get
			{
				return getPaddingTop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaddingTop14812;
		public virtual int getPaddingTop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getPaddingTop14812);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getPaddingTop14812);
		}
		public new int PaddingBottom
		{
			get
			{
				return getPaddingBottom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaddingBottom14813;
		public virtual int getPaddingBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getPaddingBottom14813);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getPaddingBottom14813);
		}
		public new int PaddingLeft
		{
			get
			{
				return getPaddingLeft();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaddingLeft14814;
		public virtual int getPaddingLeft() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getPaddingLeft14814);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getPaddingLeft14814);
		}
		public new int PaddingRight
		{
			get
			{
				return getPaddingRight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaddingRight14815;
		public virtual int getPaddingRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getPaddingRight14815);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getPaddingRight14815);
		}
		internal static global::MonoJavaBridge.MethodId _setSelected14816;
		public virtual void setSelected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setSelected14816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setSelected14816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetSelected14817;
		protected virtual void dispatchSetSelected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchSetSelected14817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchSetSelected14817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSelected14818;
		public virtual bool isSelected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isSelected14818);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isSelected14818);
		}
		public new global::android.view.ViewTreeObserver ViewTreeObserver
		{
			get
			{
				return getViewTreeObserver();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getViewTreeObserver14819;
		public virtual global::android.view.ViewTreeObserver getViewTreeObserver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getViewTreeObserver14819)) as android.view.ViewTreeObserver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getViewTreeObserver14819)) as android.view.ViewTreeObserver;
		}
		public new global::android.view.View RootView
		{
			get
			{
				return getRootView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRootView14820;
		public virtual global::android.view.View getRootView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getRootView14820)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getRootView14820)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getLocationOnScreen14821;
		public virtual void getLocationOnScreen(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._getLocationOnScreen14821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLocationOnScreen14821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLocationInWindow14822;
		public virtual void getLocationInWindow(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._getLocationInWindow14822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLocationInWindow14822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findViewWithTag14823;
		public virtual global::android.view.View findViewWithTag(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._findViewWithTag14823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._findViewWithTag14823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setId14824;
		public virtual void setId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setId14824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setId14824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTag14825;
		public virtual void setTag(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setTag14825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setTag14825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTag14826;
		public virtual void setTag(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setTag14826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setTag14826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline14827;
		public virtual int getBaseline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getBaseline14827);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getBaseline14827);
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout14828;
		public virtual void requestLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._requestLayout14828);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestLayout14828);
		}
		internal static global::MonoJavaBridge.MethodId _forceLayout14829;
		public virtual void forceLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._forceLayout14829);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._forceLayout14829);
		}
		internal static global::MonoJavaBridge.MethodId _measure14830;
		public virtual void measure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._measure14830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._measure14830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure14831;
		protected virtual void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onMeasure14831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onMeasure14831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMeasuredDimension14832;
		protected virtual void setMeasuredDimension(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setMeasuredDimension14832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setMeasuredDimension14832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _resolveSize14833;
		public static int resolveSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.View.staticClass, global::android.view.View._resolveSize14833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultSize14834;
		public static int getDefaultSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.View.staticClass, global::android.view.View._getDefaultSize14834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected new int SuggestedMinimumHeight
		{
			get
			{
				return getSuggestedMinimumHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestedMinimumHeight14835;
		protected virtual int getSuggestedMinimumHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getSuggestedMinimumHeight14835);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getSuggestedMinimumHeight14835);
		}
		protected new int SuggestedMinimumWidth
		{
			get
			{
				return getSuggestedMinimumWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestedMinimumWidth14836;
		protected virtual int getSuggestedMinimumWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getSuggestedMinimumWidth14836);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getSuggestedMinimumWidth14836);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumHeight14837;
		public virtual void setMinimumHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setMinimumHeight14837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setMinimumHeight14837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumWidth14838;
		public virtual void setMinimumWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setMinimumWidth14838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setMinimumWidth14838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startAnimation14839;
		public virtual void startAnimation(android.view.animation.Animation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._startAnimation14839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._startAnimation14839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearAnimation14840;
		public virtual void clearAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._clearAnimation14840);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._clearAnimation14840);
		}
		internal static global::MonoJavaBridge.MethodId _setAnimation14841;
		public virtual void setAnimation(android.view.animation.Animation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setAnimation14841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setAnimation14841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAnimationStart14842;
		protected virtual void onAnimationStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onAnimationStart14842);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onAnimationStart14842);
		}
		internal static global::MonoJavaBridge.MethodId _onAnimationEnd14843;
		protected virtual void onAnimationEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onAnimationEnd14843);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onAnimationEnd14843);
		}
		internal static global::MonoJavaBridge.MethodId _onSetAlpha14844;
		protected virtual bool onSetAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onSetAlpha14844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onSetAlpha14844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _playSoundEffect14845;
		public virtual void playSoundEffect(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._playSoundEffect14845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._playSoundEffect14845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performHapticFeedback14846;
		public virtual bool performHapticFeedback(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._performHapticFeedback14846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._performHapticFeedback14846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performHapticFeedback14847;
		public virtual bool performHapticFeedback(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._performHapticFeedback14847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._performHapticFeedback14847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _View14848;
		public View(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.staticClass, global::android.view.View._View14848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _View14849;
		public View(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.staticClass, global::android.view.View._View14849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _View14850;
		public View(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.staticClass, global::android.view.View._View14850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int NO_ID
		{
			get
			{
				return -1;
			}
		}
		public static int VISIBLE
		{
			get
			{
				return 0;
			}
		}
		public static int INVISIBLE
		{
			get
			{
				return 4;
			}
		}
		public static int GONE
		{
			get
			{
				return 8;
			}
		}
		public static int DRAWING_CACHE_QUALITY_LOW
		{
			get
			{
				return 524288;
			}
		}
		public static int DRAWING_CACHE_QUALITY_HIGH
		{
			get
			{
				return 1048576;
			}
		}
		public static int DRAWING_CACHE_QUALITY_AUTO
		{
			get
			{
				return 0;
			}
		}
		public static int SCROLLBARS_INSIDE_OVERLAY
		{
			get
			{
				return 0;
			}
		}
		public static int SCROLLBARS_INSIDE_INSET
		{
			get
			{
				return 16777216;
			}
		}
		public static int SCROLLBARS_OUTSIDE_OVERLAY
		{
			get
			{
				return 33554432;
			}
		}
		public static int SCROLLBARS_OUTSIDE_INSET
		{
			get
			{
				return 50331648;
			}
		}
		public static int KEEP_SCREEN_ON
		{
			get
			{
				return 67108864;
			}
		}
		public static int SOUND_EFFECTS_ENABLED
		{
			get
			{
				return 134217728;
			}
		}
		public static int HAPTIC_FEEDBACK_ENABLED
		{
			get
			{
				return 268435456;
			}
		}
		public static int FOCUSABLES_ALL
		{
			get
			{
				return 0;
			}
		}
		public static int FOCUSABLES_TOUCH_MODE
		{
			get
			{
				return 1;
			}
		}
		public static int FOCUS_BACKWARD
		{
			get
			{
				return 1;
			}
		}
		public static int FOCUS_FORWARD
		{
			get
			{
				return 2;
			}
		}
		public static int FOCUS_LEFT
		{
			get
			{
				return 17;
			}
		}
		public static int FOCUS_UP
		{
			get
			{
				return 33;
			}
		}
		public static int FOCUS_RIGHT
		{
			get
			{
				return 66;
			}
		}
		public static int FOCUS_DOWN
		{
			get
			{
				return 130;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.View.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View"));
			global::android.view.View._getResources14567 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getResources", "()Landroid/content/res/Resources;");
			global::android.view.View._getParent14568 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getParent", "()Landroid/view/ViewParent;");
			global::android.view.View._getId14569 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getId", "()I");
			global::android.view.View._getContext14570 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.view.View._isOpaque14571 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isOpaque", "()Z");
			global::android.view.View._getHandler14572 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getHandler", "()Landroid/os/Handler;");
			global::android.view.View._inflate14573 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "inflate", "(Landroid/content/Context;ILandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.view.View._getTag14574 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTag", "(I)Ljava/lang/Object;");
			global::android.view.View._getTag14575 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTag", "()Ljava/lang/Object;");
			global::android.view.View._invalidate14576 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "invalidate", "(Landroid/graphics/Rect;)V");
			global::android.view.View._invalidate14577 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "invalidate", "()V");
			global::android.view.View._invalidate14578 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "invalidate", "(IIII)V");
			global::android.view.View._layout14579 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "layout", "(IIII)V");
			global::android.view.View._onConfigurationChanged14580 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.View._isEnabled14581 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isEnabled", "()Z");
			global::android.view.View._setEnabled14582 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setEnabled", "(Z)V");
			global::android.view.View._getContentDescription14583 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getContentDescription", "()Ljava/lang/CharSequence;");
			global::android.view.View._setContentDescription14584 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setContentDescription", "(Ljava/lang/CharSequence;)V");
			global::android.view.View._getAnimation14585 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getAnimation", "()Landroid/view/animation/Animation;");
			global::android.view.View._draw14586 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.view.View._getWidth14587 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getWidth", "()I");
			global::android.view.View._getHeight14588 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getHeight", "()I");
			global::android.view.View._post14589 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "post", "(Ljava/lang/Runnable;)Z");
			global::android.view.View._postDelayed14590 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "postDelayed", "(Ljava/lang/Runnable;J)Z");
			global::android.view.View._removeCallbacks14591 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;)Z");
			global::android.view.View._onRestoreInstanceState14592 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.view.View._onSaveInstanceState14593 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.view.View._findViewById14594 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "findViewById", "(I)Landroid/view/View;");
			global::android.view.View._onKeyDown14595 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onKeyLongPress14596 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onKeyUp14597 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onKeyMultiple14598 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.view.View._onTouchEvent14599 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.View._onTrackballEvent14600 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.View._onWindowFocusChanged14601 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.view.View._hasFocus14602 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "hasFocus", "()Z");
			global::android.view.View._onAttachedToWindow14603 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onAttachedToWindow", "()V");
			global::android.view.View._onDetachedFromWindow14604 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onDetachedFromWindow", "()V");
			global::android.view.View._hasWindowFocus14605 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "hasWindowFocus", "()Z");
			global::android.view.View._dispatchKeyEvent14606 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.View._dispatchTouchEvent14607 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.View._dispatchTrackballEvent14608 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.View._dispatchPopulateAccessibilityEvent14609 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.view.View._onCreateContextMenu14610 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;)V");
			global::android.view.View._setBackgroundDrawable14611 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.View._saveHierarchyState14612 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "saveHierarchyState", "(Landroid/util/SparseArray;)V");
			global::android.view.View._restoreHierarchyState14613 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "restoreHierarchyState", "(Landroid/util/SparseArray;)V");
			global::android.view.View._initializeFadingEdge14614 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "initializeFadingEdge", "(Landroid/content/res/TypedArray;)V");
			global::android.view.View._getVerticalFadingEdgeLength14615 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getVerticalFadingEdgeLength", "()I");
			global::android.view.View._setFadingEdgeLength14616 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setFadingEdgeLength", "(I)V");
			global::android.view.View._getHorizontalFadingEdgeLength14617 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getHorizontalFadingEdgeLength", "()I");
			global::android.view.View._getVerticalScrollbarWidth14618 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getVerticalScrollbarWidth", "()I");
			global::android.view.View._getHorizontalScrollbarHeight14619 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getHorizontalScrollbarHeight", "()I");
			global::android.view.View._initializeScrollbars14620 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "initializeScrollbars", "(Landroid/content/res/TypedArray;)V");
			global::android.view.View._setOnFocusChangeListener14621 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setOnFocusChangeListener", "(Landroid/view/View$OnFocusChangeListener;)V");
			global::android.view.View._getOnFocusChangeListener14622 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getOnFocusChangeListener", "()Landroid/view/View$OnFocusChangeListener;");
			global::android.view.View._setOnClickListener14623 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.view.View._setOnLongClickListener14624 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V");
			global::android.view.View._setOnCreateContextMenuListener14625 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setOnCreateContextMenuListener", "(Landroid/view/View$OnCreateContextMenuListener;)V");
			global::android.view.View._performClick14626 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "performClick", "()Z");
			global::android.view.View._performLongClick14627 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "performLongClick", "()Z");
			global::android.view.View._showContextMenu14628 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "showContextMenu", "()Z");
			global::android.view.View._setOnKeyListener14629 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setOnKeyListener", "(Landroid/view/View$OnKeyListener;)V");
			global::android.view.View._setOnTouchListener14630 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setOnTouchListener", "(Landroid/view/View$OnTouchListener;)V");
			global::android.view.View._requestRectangleOnScreen14631 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestRectangleOnScreen", "(Landroid/graphics/Rect;)Z");
			global::android.view.View._requestRectangleOnScreen14632 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestRectangleOnScreen", "(Landroid/graphics/Rect;Z)Z");
			global::android.view.View._clearFocus14633 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "clearFocus", "()V");
			global::android.view.View._hasFocusable14634 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "hasFocusable", "()Z");
			global::android.view.View._onFocusChanged14635 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.view.View._sendAccessibilityEvent14636 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "sendAccessibilityEvent", "(I)V");
			global::android.view.View._sendAccessibilityEventUnchecked14637 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "sendAccessibilityEventUnchecked", "(Landroid/view/accessibility/AccessibilityEvent;)V");
			global::android.view.View._isFocused14638 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isFocused", "()Z");
			global::android.view.View._findFocus14639 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "findFocus", "()Landroid/view/View;");
			global::android.view.View._setScrollContainer14640 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setScrollContainer", "(Z)V");
			global::android.view.View._getDrawingCacheQuality14641 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawingCacheQuality", "()I");
			global::android.view.View._setDrawingCacheQuality14642 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setDrawingCacheQuality", "(I)V");
			global::android.view.View._getKeepScreenOn14643 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getKeepScreenOn", "()Z");
			global::android.view.View._setKeepScreenOn14644 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setKeepScreenOn", "(Z)V");
			global::android.view.View._getNextFocusLeftId14645 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getNextFocusLeftId", "()I");
			global::android.view.View._setNextFocusLeftId14646 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setNextFocusLeftId", "(I)V");
			global::android.view.View._getNextFocusRightId14647 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getNextFocusRightId", "()I");
			global::android.view.View._setNextFocusRightId14648 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setNextFocusRightId", "(I)V");
			global::android.view.View._getNextFocusUpId14649 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getNextFocusUpId", "()I");
			global::android.view.View._setNextFocusUpId14650 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setNextFocusUpId", "(I)V");
			global::android.view.View._getNextFocusDownId14651 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getNextFocusDownId", "()I");
			global::android.view.View._setNextFocusDownId14652 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setNextFocusDownId", "(I)V");
			global::android.view.View._isShown14653 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isShown", "()Z");
			global::android.view.View._fitSystemWindows14654 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "fitSystemWindows", "(Landroid/graphics/Rect;)Z");
			global::android.view.View._getVisibility14655 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getVisibility", "()I");
			global::android.view.View._setVisibility14656 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setVisibility", "(I)V");
			global::android.view.View._setFocusable14657 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setFocusable", "(Z)V");
			global::android.view.View._setFocusableInTouchMode14658 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setFocusableInTouchMode", "(Z)V");
			global::android.view.View._setSoundEffectsEnabled14659 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setSoundEffectsEnabled", "(Z)V");
			global::android.view.View._isSoundEffectsEnabled14660 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isSoundEffectsEnabled", "()Z");
			global::android.view.View._setHapticFeedbackEnabled14661 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setHapticFeedbackEnabled", "(Z)V");
			global::android.view.View._isHapticFeedbackEnabled14662 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isHapticFeedbackEnabled", "()Z");
			global::android.view.View._setWillNotDraw14663 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setWillNotDraw", "(Z)V");
			global::android.view.View._willNotDraw14664 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "willNotDraw", "()Z");
			global::android.view.View._setWillNotCacheDrawing14665 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setWillNotCacheDrawing", "(Z)V");
			global::android.view.View._willNotCacheDrawing14666 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "willNotCacheDrawing", "()Z");
			global::android.view.View._isClickable14667 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isClickable", "()Z");
			global::android.view.View._setClickable14668 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setClickable", "(Z)V");
			global::android.view.View._isLongClickable14669 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isLongClickable", "()Z");
			global::android.view.View._setLongClickable14670 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setLongClickable", "(Z)V");
			global::android.view.View._setPressed14671 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setPressed", "(Z)V");
			global::android.view.View._dispatchSetPressed14672 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchSetPressed", "(Z)V");
			global::android.view.View._isPressed14673 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isPressed", "()Z");
			global::android.view.View._isSaveEnabled14674 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isSaveEnabled", "()Z");
			global::android.view.View._setSaveEnabled14675 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setSaveEnabled", "(Z)V");
			global::android.view.View._isFocusable14676 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isFocusable", "()Z");
			global::android.view.View._isFocusableInTouchMode14677 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isFocusableInTouchMode", "()Z");
			global::android.view.View._focusSearch14678 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "focusSearch", "(I)Landroid/view/View;");
			global::android.view.View._dispatchUnhandledMove14679 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z");
			global::android.view.View._getFocusables14680 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getFocusables", "(I)Ljava/util/ArrayList;");
			global::android.view.View._addFocusables14681 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "addFocusables", "(Ljava/util/ArrayList;I)V");
			global::android.view.View._addFocusables14682 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "addFocusables", "(Ljava/util/ArrayList;II)V");
			global::android.view.View._getTouchables14683 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTouchables", "()Ljava/util/ArrayList;");
			global::android.view.View._addTouchables14684 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V");
			global::android.view.View._requestFocus14685 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestFocus", "(I)Z");
			global::android.view.View._requestFocus14686 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestFocus", "()Z");
			global::android.view.View._requestFocus14687 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z");
			global::android.view.View._requestFocusFromTouch14688 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestFocusFromTouch", "()Z");
			global::android.view.View._onStartTemporaryDetach14689 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onStartTemporaryDetach", "()V");
			global::android.view.View._onFinishTemporaryDetach14690 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onFinishTemporaryDetach", "()V");
			global::android.view.View._getKeyDispatcherState14691 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;");
			global::android.view.View._dispatchKeyEventPreIme14692 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z");
			global::android.view.View._dispatchKeyShortcutEvent14693 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.View._dispatchWindowFocusChanged14694 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchWindowFocusChanged", "(Z)V");
			global::android.view.View._dispatchVisibilityChanged14695 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchVisibilityChanged", "(Landroid/view/View;I)V");
			global::android.view.View._onVisibilityChanged14696 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onVisibilityChanged", "(Landroid/view/View;I)V");
			global::android.view.View._dispatchDisplayHint14697 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchDisplayHint", "(I)V");
			global::android.view.View._onDisplayHint14698 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onDisplayHint", "(I)V");
			global::android.view.View._dispatchWindowVisibilityChanged14699 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchWindowVisibilityChanged", "(I)V");
			global::android.view.View._onWindowVisibilityChanged14700 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onWindowVisibilityChanged", "(I)V");
			global::android.view.View._getWindowVisibility14701 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getWindowVisibility", "()I");
			global::android.view.View._getWindowVisibleDisplayFrame14702 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getWindowVisibleDisplayFrame", "(Landroid/graphics/Rect;)V");
			global::android.view.View._dispatchConfigurationChanged14703 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.View._isInTouchMode14704 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isInTouchMode", "()Z");
			global::android.view.View._onKeyPreIme14705 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onKeyPreIme", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onKeyShortcut14706 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onCheckIsTextEditor14707 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onCheckIsTextEditor", "()Z");
			global::android.view.View._onCreateInputConnection14708 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.view.View._checkInputConnectionProxy14709 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "checkInputConnectionProxy", "(Landroid/view/View;)Z");
			global::android.view.View._createContextMenu14710 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "createContextMenu", "(Landroid/view/ContextMenu;)V");
			global::android.view.View._getContextMenuInfo14711 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
			global::android.view.View._cancelLongPress14712 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "cancelLongPress", "()V");
			global::android.view.View._setTouchDelegate14713 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setTouchDelegate", "(Landroid/view/TouchDelegate;)V");
			global::android.view.View._getTouchDelegate14714 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTouchDelegate", "()Landroid/view/TouchDelegate;");
			global::android.view.View._bringToFront14715 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "bringToFront", "()V");
			global::android.view.View._onScrollChanged14716 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onScrollChanged", "(IIII)V");
			global::android.view.View._onSizeChanged14717 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onSizeChanged", "(IIII)V");
			global::android.view.View._dispatchDraw14718 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.view.View._getScrollX14719 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getScrollX", "()I");
			global::android.view.View._getScrollY14720 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getScrollY", "()I");
			global::android.view.View._getDrawingRect14721 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawingRect", "(Landroid/graphics/Rect;)V");
			global::android.view.View._getMeasuredWidth14722 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getMeasuredWidth", "()I");
			global::android.view.View._getMeasuredHeight14723 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getMeasuredHeight", "()I");
			global::android.view.View._getTop14724 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTop", "()I");
			global::android.view.View._getBottom14725 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getBottom", "()I");
			global::android.view.View._getLeft14726 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLeft", "()I");
			global::android.view.View._getRight14727 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getRight", "()I");
			global::android.view.View._getHitRect14728 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getHitRect", "(Landroid/graphics/Rect;)V");
			global::android.view.View._getFocusedRect14729 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V");
			global::android.view.View._getGlobalVisibleRect14730 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getGlobalVisibleRect", "(Landroid/graphics/Rect;Landroid/graphics/Point;)Z");
			global::android.view.View._getGlobalVisibleRect14731 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getGlobalVisibleRect", "(Landroid/graphics/Rect;)Z");
			global::android.view.View._getLocalVisibleRect14732 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLocalVisibleRect", "(Landroid/graphics/Rect;)Z");
			global::android.view.View._offsetTopAndBottom14733 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "offsetTopAndBottom", "(I)V");
			global::android.view.View._offsetLeftAndRight14734 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "offsetLeftAndRight", "(I)V");
			global::android.view.View._getLayoutParams14735 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.View._setLayoutParams14736 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.View._scrollTo14737 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "scrollTo", "(II)V");
			global::android.view.View._scrollBy14738 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "scrollBy", "(II)V");
			global::android.view.View._awakenScrollBars14739 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "awakenScrollBars", "(IZ)Z");
			global::android.view.View._awakenScrollBars14740 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "awakenScrollBars", "()Z");
			global::android.view.View._awakenScrollBars14741 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "awakenScrollBars", "(I)Z");
			global::android.view.View._postInvalidate14742 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "postInvalidate", "(IIII)V");
			global::android.view.View._postInvalidate14743 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "postInvalidate", "()V");
			global::android.view.View._postInvalidateDelayed14744 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "postInvalidateDelayed", "(J)V");
			global::android.view.View._postInvalidateDelayed14745 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "postInvalidateDelayed", "(JIIII)V");
			global::android.view.View._computeScroll14746 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeScroll", "()V");
			global::android.view.View._isHorizontalFadingEdgeEnabled14747 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isHorizontalFadingEdgeEnabled", "()Z");
			global::android.view.View._setHorizontalFadingEdgeEnabled14748 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setHorizontalFadingEdgeEnabled", "(Z)V");
			global::android.view.View._isVerticalFadingEdgeEnabled14749 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isVerticalFadingEdgeEnabled", "()Z");
			global::android.view.View._setVerticalFadingEdgeEnabled14750 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setVerticalFadingEdgeEnabled", "(Z)V");
			global::android.view.View._getTopFadingEdgeStrength14751 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTopFadingEdgeStrength", "()F");
			global::android.view.View._getBottomFadingEdgeStrength14752 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getBottomFadingEdgeStrength", "()F");
			global::android.view.View._getLeftFadingEdgeStrength14753 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLeftFadingEdgeStrength", "()F");
			global::android.view.View._getRightFadingEdgeStrength14754 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getRightFadingEdgeStrength", "()F");
			global::android.view.View._isHorizontalScrollBarEnabled14755 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isHorizontalScrollBarEnabled", "()Z");
			global::android.view.View._setHorizontalScrollBarEnabled14756 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setHorizontalScrollBarEnabled", "(Z)V");
			global::android.view.View._isVerticalScrollBarEnabled14757 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isVerticalScrollBarEnabled", "()Z");
			global::android.view.View._setVerticalScrollBarEnabled14758 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setVerticalScrollBarEnabled", "(Z)V");
			global::android.view.View._setScrollbarFadingEnabled14759 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setScrollbarFadingEnabled", "(Z)V");
			global::android.view.View._isScrollbarFadingEnabled14760 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isScrollbarFadingEnabled", "()Z");
			global::android.view.View._setScrollBarStyle14761 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setScrollBarStyle", "(I)V");
			global::android.view.View._getScrollBarStyle14762 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getScrollBarStyle", "()I");
			global::android.view.View._computeHorizontalScrollRange14763 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.view.View._computeHorizontalScrollOffset14764 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeHorizontalScrollOffset", "()I");
			global::android.view.View._computeHorizontalScrollExtent14765 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeHorizontalScrollExtent", "()I");
			global::android.view.View._computeVerticalScrollRange14766 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeVerticalScrollRange", "()I");
			global::android.view.View._computeVerticalScrollOffset14767 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.view.View._computeVerticalScrollExtent14768 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.view.View._onDrawScrollBars14769 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onDrawScrollBars", "(Landroid/graphics/Canvas;)V");
			global::android.view.View._onDraw14770 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.view.View._getWindowAttachCount14771 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getWindowAttachCount", "()I");
			global::android.view.View._getWindowToken14772 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getWindowToken", "()Landroid/os/IBinder;");
			global::android.view.View._getApplicationWindowToken14773 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getApplicationWindowToken", "()Landroid/os/IBinder;");
			global::android.view.View._dispatchSaveInstanceState14774 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.view.View._dispatchRestoreInstanceState14775 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.view.View._getDrawingTime14776 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawingTime", "()J");
			global::android.view.View._setDuplicateParentStateEnabled14777 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setDuplicateParentStateEnabled", "(Z)V");
			global::android.view.View._isDuplicateParentStateEnabled14778 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isDuplicateParentStateEnabled", "()Z");
			global::android.view.View._setDrawingCacheEnabled14779 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setDrawingCacheEnabled", "(Z)V");
			global::android.view.View._isDrawingCacheEnabled14780 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isDrawingCacheEnabled", "()Z");
			global::android.view.View._getDrawingCache14781 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawingCache", "(Z)Landroid/graphics/Bitmap;");
			global::android.view.View._getDrawingCache14782 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawingCache", "()Landroid/graphics/Bitmap;");
			global::android.view.View._destroyDrawingCache14783 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "destroyDrawingCache", "()V");
			global::android.view.View._setDrawingCacheBackgroundColor14784 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setDrawingCacheBackgroundColor", "(I)V");
			global::android.view.View._getDrawingCacheBackgroundColor14785 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawingCacheBackgroundColor", "()I");
			global::android.view.View._buildDrawingCache14786 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "buildDrawingCache", "()V");
			global::android.view.View._buildDrawingCache14787 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "buildDrawingCache", "(Z)V");
			global::android.view.View._isInEditMode14788 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isInEditMode", "()Z");
			global::android.view.View._isPaddingOffsetRequired14789 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isPaddingOffsetRequired", "()Z");
			global::android.view.View._getLeftPaddingOffset14790 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLeftPaddingOffset", "()I");
			global::android.view.View._getRightPaddingOffset14791 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getRightPaddingOffset", "()I");
			global::android.view.View._getTopPaddingOffset14792 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTopPaddingOffset", "()I");
			global::android.view.View._getBottomPaddingOffset14793 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getBottomPaddingOffset", "()I");
			global::android.view.View._getSolidColor14794 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getSolidColor", "()I");
			global::android.view.View._isLayoutRequested14795 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isLayoutRequested", "()Z");
			global::android.view.View._onLayout14796 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onLayout", "(ZIIII)V");
			global::android.view.View._onFinishInflate14797 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onFinishInflate", "()V");
			global::android.view.View._invalidateDrawable14798 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.View._scheduleDrawable14799 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.view.View._unscheduleDrawable14800 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.view.View._unscheduleDrawable14801 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.View._verifyDrawable14802 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.view.View._drawableStateChanged14803 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "drawableStateChanged", "()V");
			global::android.view.View._refreshDrawableState14804 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "refreshDrawableState", "()V");
			global::android.view.View._getDrawableState14805 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawableState", "()[I");
			global::android.view.View._onCreateDrawableState14806 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.view.View._mergeDrawableStates14807 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "mergeDrawableStates", "([I[I)[I");
			global::android.view.View._setBackgroundColor14808 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setBackgroundColor", "(I)V");
			global::android.view.View._setBackgroundResource14809 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setBackgroundResource", "(I)V");
			global::android.view.View._getBackground14810 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getBackground", "()Landroid/graphics/drawable/Drawable;");
			global::android.view.View._setPadding14811 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setPadding", "(IIII)V");
			global::android.view.View._getPaddingTop14812 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getPaddingTop", "()I");
			global::android.view.View._getPaddingBottom14813 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getPaddingBottom", "()I");
			global::android.view.View._getPaddingLeft14814 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getPaddingLeft", "()I");
			global::android.view.View._getPaddingRight14815 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getPaddingRight", "()I");
			global::android.view.View._setSelected14816 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setSelected", "(Z)V");
			global::android.view.View._dispatchSetSelected14817 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchSetSelected", "(Z)V");
			global::android.view.View._isSelected14818 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isSelected", "()Z");
			global::android.view.View._getViewTreeObserver14819 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getViewTreeObserver", "()Landroid/view/ViewTreeObserver;");
			global::android.view.View._getRootView14820 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getRootView", "()Landroid/view/View;");
			global::android.view.View._getLocationOnScreen14821 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLocationOnScreen", "([I)V");
			global::android.view.View._getLocationInWindow14822 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLocationInWindow", "([I)V");
			global::android.view.View._findViewWithTag14823 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "findViewWithTag", "(Ljava/lang/Object;)Landroid/view/View;");
			global::android.view.View._setId14824 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setId", "(I)V");
			global::android.view.View._setTag14825 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setTag", "(ILjava/lang/Object;)V");
			global::android.view.View._setTag14826 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setTag", "(Ljava/lang/Object;)V");
			global::android.view.View._getBaseline14827 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getBaseline", "()I");
			global::android.view.View._requestLayout14828 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestLayout", "()V");
			global::android.view.View._forceLayout14829 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "forceLayout", "()V");
			global::android.view.View._measure14830 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "measure", "(II)V");
			global::android.view.View._onMeasure14831 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onMeasure", "(II)V");
			global::android.view.View._setMeasuredDimension14832 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setMeasuredDimension", "(II)V");
			global::android.view.View._resolveSize14833 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "resolveSize", "(II)I");
			global::android.view.View._getDefaultSize14834 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "getDefaultSize", "(II)I");
			global::android.view.View._getSuggestedMinimumHeight14835 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getSuggestedMinimumHeight", "()I");
			global::android.view.View._getSuggestedMinimumWidth14836 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getSuggestedMinimumWidth", "()I");
			global::android.view.View._setMinimumHeight14837 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setMinimumHeight", "(I)V");
			global::android.view.View._setMinimumWidth14838 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setMinimumWidth", "(I)V");
			global::android.view.View._startAnimation14839 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "startAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.view.View._clearAnimation14840 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "clearAnimation", "()V");
			global::android.view.View._setAnimation14841 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.view.View._onAnimationStart14842 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onAnimationStart", "()V");
			global::android.view.View._onAnimationEnd14843 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onAnimationEnd", "()V");
			global::android.view.View._onSetAlpha14844 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onSetAlpha", "(I)Z");
			global::android.view.View._playSoundEffect14845 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "playSoundEffect", "(I)V");
			global::android.view.View._performHapticFeedback14846 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "performHapticFeedback", "(I)Z");
			global::android.view.View._performHapticFeedback14847 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "performHapticFeedback", "(II)Z");
			global::android.view.View._View14848 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.view.View._View14849 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.view.View._View14850 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
