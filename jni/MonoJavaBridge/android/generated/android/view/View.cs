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
			internal static global::MonoJavaBridge.MethodId _BaseSavedState9647;
			public BaseSavedState(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.BaseSavedState.staticClass, global::android.view.View.BaseSavedState._BaseSavedState9647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _BaseSavedState9648;
			public BaseSavedState(android.os.Parcelable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.BaseSavedState.staticClass, global::android.view.View.BaseSavedState._BaseSavedState9648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR9649;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					return default(global::android.os.Parcelable_Creator);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.BaseSavedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$BaseSavedState"));
				global::android.view.View.BaseSavedState._BaseSavedState9647 = @__env.GetMethodIDNoThrow(global::android.view.View.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
				global::android.view.View.BaseSavedState._BaseSavedState9648 = @__env.GetMethodIDNoThrow(global::android.view.View.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V");
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
			internal static global::MonoJavaBridge.MethodId _toString9650;
			public static global::java.lang.String toString(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._toString9650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getSize9651;
			public static int getSize(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._getSize9651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getMode9652;
			public static int getMode(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._getMode9652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _makeMeasureSpec9653;
			public static int makeMeasureSpec(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._makeMeasureSpec9653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _MeasureSpec9654;
			public MeasureSpec()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._MeasureSpec9654);
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
				global::android.view.View.MeasureSpec._toString9650 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "toString", "(I)Ljava/lang/String;");
				global::android.view.View.MeasureSpec._getSize9651 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "getSize", "(I)I");
				global::android.view.View.MeasureSpec._getMode9652 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "getMode", "(I)I");
				global::android.view.View.MeasureSpec._makeMeasureSpec9653 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "makeMeasureSpec", "(II)I");
				global::android.view.View.MeasureSpec._MeasureSpec9654 = @__env.GetMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "<init>", "()V");
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
			internal static global::MonoJavaBridge.MethodId _onClick9655;
			 void android.view.View.OnClickListener.onClick(android.view.View arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.View.OnClickListener_._onClick9655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.OnClickListener_.staticClass, global::android.view.View.OnClickListener_._onClick9655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnClickListener"));
				global::android.view.View.OnClickListener_._onClick9655 = @__env.GetMethodIDNoThrow(global::android.view.View.OnClickListener_.staticClass, "onClick", "(Landroid/view/View;)V");
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
			internal static global::MonoJavaBridge.MethodId _onCreateContextMenu9656;
			 void android.view.View.OnCreateContextMenuListener.onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.View.OnCreateContextMenuListener_._onCreateContextMenu9656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.OnCreateContextMenuListener_.staticClass, global::android.view.View.OnCreateContextMenuListener_._onCreateContextMenu9656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnCreateContextMenuListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnCreateContextMenuListener"));
				global::android.view.View.OnCreateContextMenuListener_._onCreateContextMenu9656 = @__env.GetMethodIDNoThrow(global::android.view.View.OnCreateContextMenuListener_.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V");
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
			internal static global::MonoJavaBridge.MethodId _onFocusChange9657;
			 void android.view.View.OnFocusChangeListener.onFocusChange(android.view.View arg0, bool arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.View.OnFocusChangeListener_._onFocusChange9657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.OnFocusChangeListener_.staticClass, global::android.view.View.OnFocusChangeListener_._onFocusChange9657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnFocusChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnFocusChangeListener"));
				global::android.view.View.OnFocusChangeListener_._onFocusChange9657 = @__env.GetMethodIDNoThrow(global::android.view.View.OnFocusChangeListener_.staticClass, "onFocusChange", "(Landroid/view/View;Z)V");
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
			internal static global::MonoJavaBridge.MethodId _onKey9658;
			 bool android.view.View.OnKeyListener.onKey(android.view.View arg0, int arg1, android.view.KeyEvent arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View.OnKeyListener_._onKey9658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.OnKeyListener_.staticClass, global::android.view.View.OnKeyListener_._onKey9658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnKeyListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnKeyListener"));
				global::android.view.View.OnKeyListener_._onKey9658 = @__env.GetMethodIDNoThrow(global::android.view.View.OnKeyListener_.staticClass, "onKey", "(Landroid/view/View;ILandroid/view/KeyEvent;)Z");
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
			internal static global::MonoJavaBridge.MethodId _onLongClick9659;
			 bool android.view.View.OnLongClickListener.onLongClick(android.view.View arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View.OnLongClickListener_._onLongClick9659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.OnLongClickListener_.staticClass, global::android.view.View.OnLongClickListener_._onLongClick9659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnLongClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnLongClickListener"));
				global::android.view.View.OnLongClickListener_._onLongClick9659 = @__env.GetMethodIDNoThrow(global::android.view.View.OnLongClickListener_.staticClass, "onLongClick", "(Landroid/view/View;)Z");
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
			internal static global::MonoJavaBridge.MethodId _onTouch9660;
			 bool android.view.View.OnTouchListener.onTouch(android.view.View arg0, android.view.MotionEvent arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View.OnTouchListener_._onTouch9660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.OnTouchListener_.staticClass, global::android.view.View.OnTouchListener_._onTouch9660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnTouchListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnTouchListener"));
				global::android.view.View.OnTouchListener_._onTouch9660 = @__env.GetMethodIDNoThrow(global::android.view.View.OnTouchListener_.staticClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
			}
		}
		public new global::android.content.res.Resources Resources
		{
			get
			{
				return getResources();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResources9661;
		public virtual global::android.content.res.Resources getResources() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getResources9661)) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getResources9661)) as android.content.res.Resources;
		}
		public new global::android.view.ViewParent Parent
		{
			get
			{
				return getParent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParent9662;
		public virtual global::android.view.ViewParent getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getParent9662)) as android.view.ViewParent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getParent9662)) as android.view.ViewParent;
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
		internal static global::MonoJavaBridge.MethodId _getId9663;
		public virtual int getId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getId9663);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getId9663);
		}
		public new global::android.content.Context Context
		{
			get
			{
				return getContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext9664;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getContext9664)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getContext9664)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _isOpaque9665;
		public virtual bool isOpaque() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isOpaque9665);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isOpaque9665);
		}
		public new global::android.os.Handler Handler
		{
			get
			{
				return getHandler();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHandler9666;
		public virtual global::android.os.Handler getHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getHandler9666)) as android.os.Handler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getHandler9666)) as android.os.Handler;
		}
		internal static global::MonoJavaBridge.MethodId _inflate9667;
		public static global::android.view.View inflate(android.content.Context arg0, int arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.View.staticClass, global::android.view.View._inflate9667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getTag9668;
		public virtual global::java.lang.Object getTag(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getTag9668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTag9668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
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
		internal static global::MonoJavaBridge.MethodId _getTag9669;
		public virtual global::java.lang.Object getTag() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getTag9669)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTag9669)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _invalidate9670;
		public virtual void invalidate(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._invalidate9670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._invalidate9670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invalidate9671;
		public virtual void invalidate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._invalidate9671);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._invalidate9671);
		}
		internal static global::MonoJavaBridge.MethodId _invalidate9672;
		public virtual void invalidate(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._invalidate9672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._invalidate9672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _layout9673;
		public virtual void layout(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._layout9673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._layout9673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged9674;
		protected virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onConfigurationChanged9674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onConfigurationChanged9674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled9675;
		public virtual bool isEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isEnabled9675);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isEnabled9675);
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled9676;
		public virtual void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setEnabled9676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setEnabled9676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getContentDescription9677;
		public virtual global::java.lang.CharSequence getContentDescription() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getContentDescription9677)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getContentDescription9677)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setContentDescription9678;
		public virtual void setContentDescription(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setContentDescription9678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setContentDescription9678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAnimation9679;
		public virtual global::android.view.animation.Animation getAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getAnimation9679)) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getAnimation9679)) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _draw9680;
		public virtual void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._draw9680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._draw9680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWidth9681;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getWidth9681);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getWidth9681);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeight9682;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getHeight9682);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getHeight9682);
		}
		internal static global::MonoJavaBridge.MethodId _post9683;
		public virtual bool post(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._post9683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._post9683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postDelayed9684;
		public virtual bool postDelayed(java.lang.Runnable arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._postDelayed9684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._postDelayed9684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeCallbacks9685;
		public virtual bool removeCallbacks(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._removeCallbacks9685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._removeCallbacks9685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState9686;
		protected virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onRestoreInstanceState9686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onRestoreInstanceState9686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState9687;
		protected virtual global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._onSaveInstanceState9687)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onSaveInstanceState9687)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _findViewById9688;
		public virtual global::android.view.View findViewById(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._findViewById9688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._findViewById9688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown9689;
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onKeyDown9689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onKeyDown9689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress9690;
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onKeyLongPress9690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onKeyLongPress9690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp9691;
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onKeyUp9691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onKeyUp9691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple9692;
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onKeyMultiple9692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onKeyMultiple9692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent9693;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onTouchEvent9693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onTouchEvent9693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent9694;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onTrackballEvent9694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onTrackballEvent9694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged9695;
		public virtual void onWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onWindowFocusChanged9695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onWindowFocusChanged9695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasFocus9696;
		public virtual bool hasFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._hasFocus9696);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._hasFocus9696);
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow9697;
		protected virtual void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onAttachedToWindow9697);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onAttachedToWindow9697);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow9698;
		protected virtual void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onDetachedFromWindow9698);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onDetachedFromWindow9698);
		}
		internal static global::MonoJavaBridge.MethodId _hasWindowFocus9699;
		public virtual bool hasWindowFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._hasWindowFocus9699);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._hasWindowFocus9699);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent9700;
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchKeyEvent9700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchKeyEvent9700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent9701;
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchTouchEvent9701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchTouchEvent9701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent9702;
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchTrackballEvent9702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchTrackballEvent9702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent9703;
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchPopulateAccessibilityEvent9703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchPopulateAccessibilityEvent9703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateContextMenu9704;
		protected virtual void onCreateContextMenu(android.view.ContextMenu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onCreateContextMenu9704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onCreateContextMenu9704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawable9705;
		public virtual void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setBackgroundDrawable9705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setBackgroundDrawable9705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _saveHierarchyState9706;
		public virtual void saveHierarchyState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._saveHierarchyState9706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._saveHierarchyState9706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _restoreHierarchyState9707;
		public virtual void restoreHierarchyState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._restoreHierarchyState9707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._restoreHierarchyState9707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _initializeFadingEdge9708;
		protected virtual void initializeFadingEdge(android.content.res.TypedArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._initializeFadingEdge9708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._initializeFadingEdge9708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int VerticalFadingEdgeLength
		{
			get
			{
				return getVerticalFadingEdgeLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVerticalFadingEdgeLength9709;
		public virtual int getVerticalFadingEdgeLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getVerticalFadingEdgeLength9709);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getVerticalFadingEdgeLength9709);
		}
		internal static global::MonoJavaBridge.MethodId _setFadingEdgeLength9710;
		public virtual void setFadingEdgeLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setFadingEdgeLength9710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setFadingEdgeLength9710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int HorizontalFadingEdgeLength
		{
			get
			{
				return getHorizontalFadingEdgeLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHorizontalFadingEdgeLength9711;
		public virtual int getHorizontalFadingEdgeLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getHorizontalFadingEdgeLength9711);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getHorizontalFadingEdgeLength9711);
		}
		public new int VerticalScrollbarWidth
		{
			get
			{
				return getVerticalScrollbarWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVerticalScrollbarWidth9712;
		public virtual int getVerticalScrollbarWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getVerticalScrollbarWidth9712);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getVerticalScrollbarWidth9712);
		}
		protected new int HorizontalScrollbarHeight
		{
			get
			{
				return getHorizontalScrollbarHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHorizontalScrollbarHeight9713;
		protected virtual int getHorizontalScrollbarHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getHorizontalScrollbarHeight9713);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getHorizontalScrollbarHeight9713);
		}
		internal static global::MonoJavaBridge.MethodId _initializeScrollbars9714;
		protected virtual void initializeScrollbars(android.content.res.TypedArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._initializeScrollbars9714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._initializeScrollbars9714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnFocusChangeListener9715;
		public virtual void setOnFocusChangeListener(android.view.View.OnFocusChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setOnFocusChangeListener9715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setOnFocusChangeListener9715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnFocusChangeListener9716;
		public virtual global::android.view.View.OnFocusChangeListener getOnFocusChangeListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.View.OnFocusChangeListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getOnFocusChangeListener9716)) as android.view.View.OnFocusChangeListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.View.OnFocusChangeListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getOnFocusChangeListener9716)) as android.view.View.OnFocusChangeListener;
		}
		internal static global::MonoJavaBridge.MethodId _setOnClickListener9717;
		public virtual void setOnClickListener(android.view.View.OnClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setOnClickListener9717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setOnClickListener9717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnLongClickListener9718;
		public virtual void setOnLongClickListener(android.view.View.OnLongClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setOnLongClickListener9718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setOnLongClickListener9718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnCreateContextMenuListener9719;
		public virtual void setOnCreateContextMenuListener(android.view.View.OnCreateContextMenuListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setOnCreateContextMenuListener9719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setOnCreateContextMenuListener9719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performClick9720;
		public virtual bool performClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._performClick9720);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._performClick9720);
		}
		internal static global::MonoJavaBridge.MethodId _performLongClick9721;
		public virtual bool performLongClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._performLongClick9721);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._performLongClick9721);
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenu9722;
		public virtual bool showContextMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._showContextMenu9722);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._showContextMenu9722);
		}
		internal static global::MonoJavaBridge.MethodId _setOnKeyListener9723;
		public virtual void setOnKeyListener(android.view.View.OnKeyListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setOnKeyListener9723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setOnKeyListener9723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnTouchListener9724;
		public virtual void setOnTouchListener(android.view.View.OnTouchListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setOnTouchListener9724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setOnTouchListener9724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestRectangleOnScreen9725;
		public virtual bool requestRectangleOnScreen(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._requestRectangleOnScreen9725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestRectangleOnScreen9725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestRectangleOnScreen9726;
		public virtual bool requestRectangleOnScreen(android.graphics.Rect arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._requestRectangleOnScreen9726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestRectangleOnScreen9726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearFocus9727;
		public virtual void clearFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._clearFocus9727);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._clearFocus9727);
		}
		internal static global::MonoJavaBridge.MethodId _hasFocusable9728;
		public virtual bool hasFocusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._hasFocusable9728);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._hasFocusable9728);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged9729;
		protected virtual void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onFocusChanged9729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onFocusChanged9729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sendAccessibilityEvent9730;
		public virtual void sendAccessibilityEvent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._sendAccessibilityEvent9730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._sendAccessibilityEvent9730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendAccessibilityEventUnchecked9731;
		public virtual void sendAccessibilityEventUnchecked(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._sendAccessibilityEventUnchecked9731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._sendAccessibilityEventUnchecked9731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFocused9732;
		public virtual bool isFocused() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isFocused9732);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isFocused9732);
		}
		internal static global::MonoJavaBridge.MethodId _findFocus9733;
		public virtual global::android.view.View findFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._findFocus9733)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._findFocus9733)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setScrollContainer9734;
		public virtual void setScrollContainer(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setScrollContainer9734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setScrollContainer9734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDrawingCacheQuality9735;
		public virtual int getDrawingCacheQuality() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getDrawingCacheQuality9735);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawingCacheQuality9735);
		}
		internal static global::MonoJavaBridge.MethodId _setDrawingCacheQuality9736;
		public virtual void setDrawingCacheQuality(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setDrawingCacheQuality9736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setDrawingCacheQuality9736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getKeepScreenOn9737;
		public virtual bool getKeepScreenOn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._getKeepScreenOn9737);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getKeepScreenOn9737);
		}
		internal static global::MonoJavaBridge.MethodId _setKeepScreenOn9738;
		public virtual void setKeepScreenOn(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setKeepScreenOn9738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setKeepScreenOn9738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNextFocusLeftId9739;
		public virtual int getNextFocusLeftId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getNextFocusLeftId9739);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getNextFocusLeftId9739);
		}
		internal static global::MonoJavaBridge.MethodId _setNextFocusLeftId9740;
		public virtual void setNextFocusLeftId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setNextFocusLeftId9740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setNextFocusLeftId9740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNextFocusRightId9741;
		public virtual int getNextFocusRightId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getNextFocusRightId9741);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getNextFocusRightId9741);
		}
		internal static global::MonoJavaBridge.MethodId _setNextFocusRightId9742;
		public virtual void setNextFocusRightId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setNextFocusRightId9742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setNextFocusRightId9742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNextFocusUpId9743;
		public virtual int getNextFocusUpId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getNextFocusUpId9743);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getNextFocusUpId9743);
		}
		internal static global::MonoJavaBridge.MethodId _setNextFocusUpId9744;
		public virtual void setNextFocusUpId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setNextFocusUpId9744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setNextFocusUpId9744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNextFocusDownId9745;
		public virtual int getNextFocusDownId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getNextFocusDownId9745);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getNextFocusDownId9745);
		}
		internal static global::MonoJavaBridge.MethodId _setNextFocusDownId9746;
		public virtual void setNextFocusDownId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setNextFocusDownId9746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setNextFocusDownId9746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isShown9747;
		public virtual bool isShown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isShown9747);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isShown9747);
		}
		internal static global::MonoJavaBridge.MethodId _fitSystemWindows9748;
		protected virtual bool fitSystemWindows(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._fitSystemWindows9748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._fitSystemWindows9748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getVisibility9749;
		public virtual int getVisibility() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getVisibility9749);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getVisibility9749);
		}
		internal static global::MonoJavaBridge.MethodId _setVisibility9750;
		public virtual void setVisibility(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setVisibility9750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setVisibility9750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFocusable9751;
		public virtual void setFocusable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setFocusable9751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setFocusable9751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFocusableInTouchMode9752;
		public virtual void setFocusableInTouchMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setFocusableInTouchMode9752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setFocusableInTouchMode9752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSoundEffectsEnabled9753;
		public virtual void setSoundEffectsEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setSoundEffectsEnabled9753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setSoundEffectsEnabled9753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSoundEffectsEnabled9754;
		public virtual bool isSoundEffectsEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isSoundEffectsEnabled9754);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isSoundEffectsEnabled9754);
		}
		internal static global::MonoJavaBridge.MethodId _setHapticFeedbackEnabled9755;
		public virtual void setHapticFeedbackEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setHapticFeedbackEnabled9755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setHapticFeedbackEnabled9755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isHapticFeedbackEnabled9756;
		public virtual bool isHapticFeedbackEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isHapticFeedbackEnabled9756);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isHapticFeedbackEnabled9756);
		}
		internal static global::MonoJavaBridge.MethodId _setWillNotDraw9757;
		public virtual void setWillNotDraw(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setWillNotDraw9757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setWillNotDraw9757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _willNotDraw9758;
		public virtual bool willNotDraw() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._willNotDraw9758);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._willNotDraw9758);
		}
		internal static global::MonoJavaBridge.MethodId _setWillNotCacheDrawing9759;
		public virtual void setWillNotCacheDrawing(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setWillNotCacheDrawing9759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setWillNotCacheDrawing9759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _willNotCacheDrawing9760;
		public virtual bool willNotCacheDrawing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._willNotCacheDrawing9760);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._willNotCacheDrawing9760);
		}
		internal static global::MonoJavaBridge.MethodId _isClickable9761;
		public virtual bool isClickable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isClickable9761);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isClickable9761);
		}
		internal static global::MonoJavaBridge.MethodId _setClickable9762;
		public virtual void setClickable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setClickable9762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setClickable9762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLongClickable9763;
		public virtual bool isLongClickable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isLongClickable9763);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isLongClickable9763);
		}
		internal static global::MonoJavaBridge.MethodId _setLongClickable9764;
		public virtual void setLongClickable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setLongClickable9764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setLongClickable9764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPressed9765;
		public virtual void setPressed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setPressed9765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setPressed9765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetPressed9766;
		protected virtual void dispatchSetPressed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchSetPressed9766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchSetPressed9766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPressed9767;
		public virtual bool isPressed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isPressed9767);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isPressed9767);
		}
		internal static global::MonoJavaBridge.MethodId _isSaveEnabled9768;
		public virtual bool isSaveEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isSaveEnabled9768);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isSaveEnabled9768);
		}
		internal static global::MonoJavaBridge.MethodId _setSaveEnabled9769;
		public virtual void setSaveEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setSaveEnabled9769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setSaveEnabled9769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFocusable9770;
		public virtual bool isFocusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isFocusable9770);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isFocusable9770);
		}
		internal static global::MonoJavaBridge.MethodId _isFocusableInTouchMode9771;
		public virtual bool isFocusableInTouchMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isFocusableInTouchMode9771);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isFocusableInTouchMode9771);
		}
		internal static global::MonoJavaBridge.MethodId _focusSearch9772;
		public virtual global::android.view.View focusSearch(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._focusSearch9772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._focusSearch9772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchUnhandledMove9773;
		public virtual bool dispatchUnhandledMove(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchUnhandledMove9773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchUnhandledMove9773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFocusables9774;
		public virtual global::java.util.ArrayList getFocusables(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getFocusables9774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getFocusables9774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _addFocusables9775;
		public virtual void addFocusables(java.util.ArrayList arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._addFocusables9775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._addFocusables9775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFocusables9776;
		public virtual void addFocusables(java.util.ArrayList arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._addFocusables9776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._addFocusables9776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.util.ArrayList Touchables
		{
			get
			{
				return getTouchables();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTouchables9777;
		public virtual global::java.util.ArrayList getTouchables() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getTouchables9777)) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTouchables9777)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _addTouchables9778;
		public virtual void addTouchables(java.util.ArrayList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._addTouchables9778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._addTouchables9778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus9779;
		public virtual bool requestFocus(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._requestFocus9779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestFocus9779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus9780;
		public virtual bool requestFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._requestFocus9780);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestFocus9780);
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus9781;
		public virtual bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._requestFocus9781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestFocus9781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocusFromTouch9782;
		public virtual bool requestFocusFromTouch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._requestFocusFromTouch9782);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestFocusFromTouch9782);
		}
		internal static global::MonoJavaBridge.MethodId _onStartTemporaryDetach9783;
		public virtual void onStartTemporaryDetach() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onStartTemporaryDetach9783);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onStartTemporaryDetach9783);
		}
		internal static global::MonoJavaBridge.MethodId _onFinishTemporaryDetach9784;
		public virtual void onFinishTemporaryDetach() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onFinishTemporaryDetach9784);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onFinishTemporaryDetach9784);
		}
		public new global::android.view.KeyEvent.DispatcherState KeyDispatcherState
		{
			get
			{
				return getKeyDispatcherState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeyDispatcherState9785;
		public virtual global::android.view.KeyEvent.DispatcherState getKeyDispatcherState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getKeyDispatcherState9785)) as android.view.KeyEvent.DispatcherState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getKeyDispatcherState9785)) as android.view.KeyEvent.DispatcherState;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEventPreIme9786;
		public virtual bool dispatchKeyEventPreIme(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchKeyEventPreIme9786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchKeyEventPreIme9786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyShortcutEvent9787;
		public virtual bool dispatchKeyShortcutEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._dispatchKeyShortcutEvent9787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchKeyShortcutEvent9787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowFocusChanged9788;
		public virtual void dispatchWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchWindowFocusChanged9788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchWindowFocusChanged9788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchVisibilityChanged9789;
		protected virtual void dispatchVisibilityChanged(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchVisibilityChanged9789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchVisibilityChanged9789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onVisibilityChanged9790;
		protected virtual void onVisibilityChanged(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onVisibilityChanged9790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onVisibilityChanged9790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDisplayHint9791;
		public virtual void dispatchDisplayHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchDisplayHint9791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchDisplayHint9791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDisplayHint9792;
		protected virtual void onDisplayHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onDisplayHint9792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onDisplayHint9792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowVisibilityChanged9793;
		public virtual void dispatchWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchWindowVisibilityChanged9793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchWindowVisibilityChanged9793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowVisibilityChanged9794;
		protected virtual void onWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onWindowVisibilityChanged9794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onWindowVisibilityChanged9794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int WindowVisibility
		{
			get
			{
				return getWindowVisibility();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindowVisibility9795;
		public virtual int getWindowVisibility() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getWindowVisibility9795);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getWindowVisibility9795);
		}
		internal static global::MonoJavaBridge.MethodId _getWindowVisibleDisplayFrame9796;
		public virtual void getWindowVisibleDisplayFrame(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._getWindowVisibleDisplayFrame9796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getWindowVisibleDisplayFrame9796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchConfigurationChanged9797;
		public virtual void dispatchConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchConfigurationChanged9797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchConfigurationChanged9797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInTouchMode9798;
		public virtual bool isInTouchMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isInTouchMode9798);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isInTouchMode9798);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyPreIme9799;
		public virtual bool onKeyPreIme(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onKeyPreIme9799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onKeyPreIme9799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyShortcut9800;
		public virtual bool onKeyShortcut(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onKeyShortcut9800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onKeyShortcut9800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCheckIsTextEditor9801;
		public virtual bool onCheckIsTextEditor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onCheckIsTextEditor9801);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onCheckIsTextEditor9801);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputConnection9802;
		public virtual global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._onCreateInputConnection9802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onCreateInputConnection9802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
		}
		internal static global::MonoJavaBridge.MethodId _checkInputConnectionProxy9803;
		public virtual bool checkInputConnectionProxy(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._checkInputConnectionProxy9803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._checkInputConnectionProxy9803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createContextMenu9804;
		public virtual void createContextMenu(android.view.ContextMenu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._createContextMenu9804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._createContextMenu9804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new global::android.view.ContextMenu_ContextMenuInfo ContextMenuInfo
		{
			get
			{
				return getContextMenuInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContextMenuInfo9805;
		protected virtual global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getContextMenuInfo9805)) as android.view.ContextMenu_ContextMenuInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getContextMenuInfo9805)) as android.view.ContextMenu_ContextMenuInfo;
		}
		internal static global::MonoJavaBridge.MethodId _cancelLongPress9806;
		public virtual void cancelLongPress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._cancelLongPress9806);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._cancelLongPress9806);
		}
		internal static global::MonoJavaBridge.MethodId _setTouchDelegate9807;
		public virtual void setTouchDelegate(android.view.TouchDelegate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setTouchDelegate9807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setTouchDelegate9807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTouchDelegate9808;
		public virtual global::android.view.TouchDelegate getTouchDelegate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getTouchDelegate9808)) as android.view.TouchDelegate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTouchDelegate9808)) as android.view.TouchDelegate;
		}
		internal static global::MonoJavaBridge.MethodId _bringToFront9809;
		public virtual void bringToFront() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._bringToFront9809);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._bringToFront9809);
		}
		internal static global::MonoJavaBridge.MethodId _onScrollChanged9810;
		protected virtual void onScrollChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onScrollChanged9810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onScrollChanged9810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged9811;
		protected virtual void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onSizeChanged9811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onSizeChanged9811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw9812;
		protected virtual void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchDraw9812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchDraw9812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ScrollX
		{
			get
			{
				return getScrollX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollX9813;
		public virtual int getScrollX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getScrollX9813);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getScrollX9813);
		}
		public new int ScrollY
		{
			get
			{
				return getScrollY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollY9814;
		public virtual int getScrollY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getScrollY9814);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getScrollY9814);
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingRect9815;
		public virtual void getDrawingRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._getDrawingRect9815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawingRect9815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MeasuredWidth
		{
			get
			{
				return getMeasuredWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMeasuredWidth9816;
		public virtual int getMeasuredWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getMeasuredWidth9816);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getMeasuredWidth9816);
		}
		public new int MeasuredHeight
		{
			get
			{
				return getMeasuredHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMeasuredHeight9817;
		public virtual int getMeasuredHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getMeasuredHeight9817);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getMeasuredHeight9817);
		}
		public new int Top
		{
			get
			{
				return getTop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTop9818;
		public virtual int getTop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getTop9818);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTop9818);
		}
		public new int Bottom
		{
			get
			{
				return getBottom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottom9819;
		public virtual int getBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getBottom9819);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getBottom9819);
		}
		public new int Left
		{
			get
			{
				return getLeft();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeft9820;
		public virtual int getLeft() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getLeft9820);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLeft9820);
		}
		public new int Right
		{
			get
			{
				return getRight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRight9821;
		public virtual int getRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getRight9821);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getRight9821);
		}
		internal static global::MonoJavaBridge.MethodId _getHitRect9822;
		public virtual void getHitRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._getHitRect9822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getHitRect9822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFocusedRect9823;
		public virtual void getFocusedRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._getFocusedRect9823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getFocusedRect9823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalVisibleRect9824;
		public virtual bool getGlobalVisibleRect(android.graphics.Rect arg0, android.graphics.Point arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._getGlobalVisibleRect9824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getGlobalVisibleRect9824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalVisibleRect9825;
		public virtual bool getGlobalVisibleRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._getGlobalVisibleRect9825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getGlobalVisibleRect9825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLocalVisibleRect9826;
		public virtual bool getLocalVisibleRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._getLocalVisibleRect9826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLocalVisibleRect9826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offsetTopAndBottom9827;
		public virtual void offsetTopAndBottom(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._offsetTopAndBottom9827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._offsetTopAndBottom9827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offsetLeftAndRight9828;
		public virtual void offsetLeftAndRight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._offsetLeftAndRight9828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._offsetLeftAndRight9828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLayoutParams9829;
		public virtual global::android.view.ViewGroup.LayoutParams getLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getLayoutParams9829)) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLayoutParams9829)) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutParams9830;
		public virtual void setLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setLayoutParams9830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setLayoutParams9830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scrollTo9831;
		public virtual void scrollTo(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._scrollTo9831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._scrollTo9831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scrollBy9832;
		public virtual void scrollBy(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._scrollBy9832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._scrollBy9832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _awakenScrollBars9833;
		protected virtual bool awakenScrollBars(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._awakenScrollBars9833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._awakenScrollBars9833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _awakenScrollBars9834;
		protected virtual bool awakenScrollBars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._awakenScrollBars9834);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._awakenScrollBars9834);
		}
		internal static global::MonoJavaBridge.MethodId _awakenScrollBars9835;
		protected virtual bool awakenScrollBars(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._awakenScrollBars9835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._awakenScrollBars9835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidate9836;
		public virtual void postInvalidate(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._postInvalidate9836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._postInvalidate9836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidate9837;
		public virtual void postInvalidate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._postInvalidate9837);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._postInvalidate9837);
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidateDelayed9838;
		public virtual void postInvalidateDelayed(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._postInvalidateDelayed9838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._postInvalidateDelayed9838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidateDelayed9839;
		public virtual void postInvalidateDelayed(long arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._postInvalidateDelayed9839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._postInvalidateDelayed9839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll9840;
		public virtual void computeScroll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._computeScroll9840);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeScroll9840);
		}
		internal static global::MonoJavaBridge.MethodId _isHorizontalFadingEdgeEnabled9841;
		public virtual bool isHorizontalFadingEdgeEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isHorizontalFadingEdgeEnabled9841);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isHorizontalFadingEdgeEnabled9841);
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalFadingEdgeEnabled9842;
		public virtual void setHorizontalFadingEdgeEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setHorizontalFadingEdgeEnabled9842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setHorizontalFadingEdgeEnabled9842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isVerticalFadingEdgeEnabled9843;
		public virtual bool isVerticalFadingEdgeEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isVerticalFadingEdgeEnabled9843);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isVerticalFadingEdgeEnabled9843);
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalFadingEdgeEnabled9844;
		public virtual void setVerticalFadingEdgeEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setVerticalFadingEdgeEnabled9844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setVerticalFadingEdgeEnabled9844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new float TopFadingEdgeStrength
		{
			get
			{
				return getTopFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTopFadingEdgeStrength9845;
		protected virtual float getTopFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.View._getTopFadingEdgeStrength9845);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTopFadingEdgeStrength9845);
		}
		protected new float BottomFadingEdgeStrength
		{
			get
			{
				return getBottomFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottomFadingEdgeStrength9846;
		protected virtual float getBottomFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.View._getBottomFadingEdgeStrength9846);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getBottomFadingEdgeStrength9846);
		}
		protected new float LeftFadingEdgeStrength
		{
			get
			{
				return getLeftFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeftFadingEdgeStrength9847;
		protected virtual float getLeftFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.View._getLeftFadingEdgeStrength9847);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLeftFadingEdgeStrength9847);
		}
		protected new float RightFadingEdgeStrength
		{
			get
			{
				return getRightFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRightFadingEdgeStrength9848;
		protected virtual float getRightFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.View._getRightFadingEdgeStrength9848);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getRightFadingEdgeStrength9848);
		}
		internal static global::MonoJavaBridge.MethodId _isHorizontalScrollBarEnabled9849;
		public virtual bool isHorizontalScrollBarEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isHorizontalScrollBarEnabled9849);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isHorizontalScrollBarEnabled9849);
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalScrollBarEnabled9850;
		public virtual void setHorizontalScrollBarEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setHorizontalScrollBarEnabled9850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setHorizontalScrollBarEnabled9850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isVerticalScrollBarEnabled9851;
		public virtual bool isVerticalScrollBarEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isVerticalScrollBarEnabled9851);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isVerticalScrollBarEnabled9851);
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalScrollBarEnabled9852;
		public virtual void setVerticalScrollBarEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setVerticalScrollBarEnabled9852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setVerticalScrollBarEnabled9852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setScrollbarFadingEnabled9853;
		public virtual void setScrollbarFadingEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setScrollbarFadingEnabled9853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setScrollbarFadingEnabled9853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isScrollbarFadingEnabled9854;
		public virtual bool isScrollbarFadingEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isScrollbarFadingEnabled9854);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isScrollbarFadingEnabled9854);
		}
		internal static global::MonoJavaBridge.MethodId _setScrollBarStyle9855;
		public virtual void setScrollBarStyle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setScrollBarStyle9855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setScrollBarStyle9855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getScrollBarStyle9856;
		public virtual int getScrollBarStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getScrollBarStyle9856);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getScrollBarStyle9856);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange9857;
		protected virtual int computeHorizontalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._computeHorizontalScrollRange9857);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeHorizontalScrollRange9857);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollOffset9858;
		protected virtual int computeHorizontalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._computeHorizontalScrollOffset9858);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeHorizontalScrollOffset9858);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollExtent9859;
		protected virtual int computeHorizontalScrollExtent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._computeHorizontalScrollExtent9859);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeHorizontalScrollExtent9859);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange9860;
		protected virtual int computeVerticalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._computeVerticalScrollRange9860);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeVerticalScrollRange9860);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollOffset9861;
		protected virtual int computeVerticalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._computeVerticalScrollOffset9861);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeVerticalScrollOffset9861);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent9862;
		protected virtual int computeVerticalScrollExtent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._computeVerticalScrollExtent9862);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._computeVerticalScrollExtent9862);
		}
		internal static global::MonoJavaBridge.MethodId _onDrawScrollBars9863;
		protected virtual void onDrawScrollBars(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onDrawScrollBars9863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onDrawScrollBars9863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDraw9864;
		protected virtual void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onDraw9864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onDraw9864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new int WindowAttachCount
		{
			get
			{
				return getWindowAttachCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindowAttachCount9865;
		protected virtual int getWindowAttachCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getWindowAttachCount9865);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getWindowAttachCount9865);
		}
		public new global::android.os.IBinder WindowToken
		{
			get
			{
				return getWindowToken();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindowToken9866;
		public virtual global::android.os.IBinder getWindowToken() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getWindowToken9866)) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getWindowToken9866)) as android.os.IBinder;
		}
		public new global::android.os.IBinder ApplicationWindowToken
		{
			get
			{
				return getApplicationWindowToken();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationWindowToken9867;
		public virtual global::android.os.IBinder getApplicationWindowToken() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getApplicationWindowToken9867)) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getApplicationWindowToken9867)) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSaveInstanceState9868;
		protected virtual void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchSaveInstanceState9868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchSaveInstanceState9868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchRestoreInstanceState9869;
		protected virtual void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchRestoreInstanceState9869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchRestoreInstanceState9869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long DrawingTime
		{
			get
			{
				return getDrawingTime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingTime9870;
		public virtual long getDrawingTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.View._getDrawingTime9870);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawingTime9870);
		}
		internal static global::MonoJavaBridge.MethodId _setDuplicateParentStateEnabled9871;
		public virtual void setDuplicateParentStateEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setDuplicateParentStateEnabled9871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setDuplicateParentStateEnabled9871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDuplicateParentStateEnabled9872;
		public virtual bool isDuplicateParentStateEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isDuplicateParentStateEnabled9872);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isDuplicateParentStateEnabled9872);
		}
		internal static global::MonoJavaBridge.MethodId _setDrawingCacheEnabled9873;
		public virtual void setDrawingCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setDrawingCacheEnabled9873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setDrawingCacheEnabled9873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDrawingCacheEnabled9874;
		public virtual bool isDrawingCacheEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isDrawingCacheEnabled9874);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isDrawingCacheEnabled9874);
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingCache9875;
		public virtual global::android.graphics.Bitmap getDrawingCache(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getDrawingCache9875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawingCache9875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
		}
		public new global::android.graphics.Bitmap DrawingCache
		{
			get
			{
				return getDrawingCache();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingCache9876;
		public virtual global::android.graphics.Bitmap getDrawingCache() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getDrawingCache9876)) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawingCache9876)) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _destroyDrawingCache9877;
		public virtual void destroyDrawingCache() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._destroyDrawingCache9877);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._destroyDrawingCache9877);
		}
		internal static global::MonoJavaBridge.MethodId _setDrawingCacheBackgroundColor9878;
		public virtual void setDrawingCacheBackgroundColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setDrawingCacheBackgroundColor9878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setDrawingCacheBackgroundColor9878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDrawingCacheBackgroundColor9879;
		public virtual int getDrawingCacheBackgroundColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getDrawingCacheBackgroundColor9879);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawingCacheBackgroundColor9879);
		}
		internal static global::MonoJavaBridge.MethodId _buildDrawingCache9880;
		public virtual void buildDrawingCache() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._buildDrawingCache9880);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._buildDrawingCache9880);
		}
		internal static global::MonoJavaBridge.MethodId _buildDrawingCache9881;
		public virtual void buildDrawingCache(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._buildDrawingCache9881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._buildDrawingCache9881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInEditMode9882;
		public virtual bool isInEditMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isInEditMode9882);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isInEditMode9882);
		}
		internal static global::MonoJavaBridge.MethodId _isPaddingOffsetRequired9883;
		protected virtual bool isPaddingOffsetRequired() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isPaddingOffsetRequired9883);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isPaddingOffsetRequired9883);
		}
		protected new int LeftPaddingOffset
		{
			get
			{
				return getLeftPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeftPaddingOffset9884;
		protected virtual int getLeftPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getLeftPaddingOffset9884);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLeftPaddingOffset9884);
		}
		protected new int RightPaddingOffset
		{
			get
			{
				return getRightPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRightPaddingOffset9885;
		protected virtual int getRightPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getRightPaddingOffset9885);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getRightPaddingOffset9885);
		}
		protected new int TopPaddingOffset
		{
			get
			{
				return getTopPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTopPaddingOffset9886;
		protected virtual int getTopPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getTopPaddingOffset9886);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getTopPaddingOffset9886);
		}
		protected new int BottomPaddingOffset
		{
			get
			{
				return getBottomPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPaddingOffset9887;
		protected virtual int getBottomPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getBottomPaddingOffset9887);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getBottomPaddingOffset9887);
		}
		public new int SolidColor
		{
			get
			{
				return getSolidColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSolidColor9888;
		public virtual int getSolidColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getSolidColor9888);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getSolidColor9888);
		}
		internal static global::MonoJavaBridge.MethodId _isLayoutRequested9889;
		public virtual bool isLayoutRequested() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isLayoutRequested9889);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isLayoutRequested9889);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout9890;
		protected virtual void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onLayout9890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onLayout9890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate9891;
		protected virtual void onFinishInflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onFinishInflate9891);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onFinishInflate9891);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable9892;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._invalidateDrawable9892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._invalidateDrawable9892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleDrawable9893;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._scheduleDrawable9893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._scheduleDrawable9893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable9894;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._unscheduleDrawable9894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._unscheduleDrawable9894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable9895;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._unscheduleDrawable9895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._unscheduleDrawable9895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable9896;
		protected virtual bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._verifyDrawable9896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._verifyDrawable9896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged9897;
		protected virtual void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._drawableStateChanged9897);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._drawableStateChanged9897);
		}
		internal static global::MonoJavaBridge.MethodId _refreshDrawableState9898;
		public virtual void refreshDrawableState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._refreshDrawableState9898);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._refreshDrawableState9898);
		}
		public new int[] DrawableState
		{
			get
			{
				return getDrawableState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawableState9899;
		public virtual int[] getDrawableState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getDrawableState9899)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getDrawableState9899)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState9900;
		protected virtual int[] onCreateDrawableState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._onCreateDrawableState9900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onCreateDrawableState9900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _mergeDrawableStates9901;
		protected static int[] mergeDrawableStates(int[] arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.view.View.staticClass, global::android.view.View._mergeDrawableStates9901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundColor9902;
		public virtual void setBackgroundColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setBackgroundColor9902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setBackgroundColor9902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundResource9903;
		public virtual void setBackgroundResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setBackgroundResource9903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setBackgroundResource9903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable Background
		{
			get
			{
				return getBackground();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBackground9904;
		public virtual global::android.graphics.drawable.Drawable getBackground() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getBackground9904)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getBackground9904)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setPadding9905;
		public virtual void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setPadding9905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setPadding9905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new int PaddingTop
		{
			get
			{
				return getPaddingTop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaddingTop9906;
		public virtual int getPaddingTop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getPaddingTop9906);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getPaddingTop9906);
		}
		public new int PaddingBottom
		{
			get
			{
				return getPaddingBottom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaddingBottom9907;
		public virtual int getPaddingBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getPaddingBottom9907);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getPaddingBottom9907);
		}
		public new int PaddingLeft
		{
			get
			{
				return getPaddingLeft();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaddingLeft9908;
		public virtual int getPaddingLeft() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getPaddingLeft9908);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getPaddingLeft9908);
		}
		public new int PaddingRight
		{
			get
			{
				return getPaddingRight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaddingRight9909;
		public virtual int getPaddingRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getPaddingRight9909);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getPaddingRight9909);
		}
		internal static global::MonoJavaBridge.MethodId _setSelected9910;
		public virtual void setSelected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setSelected9910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setSelected9910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetSelected9911;
		protected virtual void dispatchSetSelected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._dispatchSetSelected9911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._dispatchSetSelected9911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSelected9912;
		public virtual bool isSelected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._isSelected9912);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._isSelected9912);
		}
		public new global::android.view.ViewTreeObserver ViewTreeObserver
		{
			get
			{
				return getViewTreeObserver();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getViewTreeObserver9913;
		public virtual global::android.view.ViewTreeObserver getViewTreeObserver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getViewTreeObserver9913)) as android.view.ViewTreeObserver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getViewTreeObserver9913)) as android.view.ViewTreeObserver;
		}
		public new global::android.view.View RootView
		{
			get
			{
				return getRootView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRootView9914;
		public virtual global::android.view.View getRootView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._getRootView9914)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getRootView9914)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getLocationOnScreen9915;
		public virtual void getLocationOnScreen(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._getLocationOnScreen9915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLocationOnScreen9915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLocationInWindow9916;
		public virtual void getLocationInWindow(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._getLocationInWindow9916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getLocationInWindow9916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findViewWithTag9917;
		public virtual global::android.view.View findViewWithTag(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.View._findViewWithTag9917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._findViewWithTag9917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setId9918;
		public virtual void setId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setId9918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setId9918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTag9919;
		public virtual void setTag(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setTag9919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setTag9919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTag9920;
		public virtual void setTag(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setTag9920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setTag9920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline9921;
		public virtual int getBaseline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getBaseline9921);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getBaseline9921);
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout9922;
		public virtual void requestLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._requestLayout9922);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._requestLayout9922);
		}
		internal static global::MonoJavaBridge.MethodId _forceLayout9923;
		public virtual void forceLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._forceLayout9923);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._forceLayout9923);
		}
		internal static global::MonoJavaBridge.MethodId _measure9924;
		public virtual void measure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._measure9924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._measure9924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure9925;
		protected virtual void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onMeasure9925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onMeasure9925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMeasuredDimension9926;
		protected virtual void setMeasuredDimension(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setMeasuredDimension9926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setMeasuredDimension9926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _resolveSize9927;
		public static int resolveSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.View.staticClass, global::android.view.View._resolveSize9927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultSize9928;
		public static int getDefaultSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.View.staticClass, global::android.view.View._getDefaultSize9928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected new int SuggestedMinimumHeight
		{
			get
			{
				return getSuggestedMinimumHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestedMinimumHeight9929;
		protected virtual int getSuggestedMinimumHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getSuggestedMinimumHeight9929);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getSuggestedMinimumHeight9929);
		}
		protected new int SuggestedMinimumWidth
		{
			get
			{
				return getSuggestedMinimumWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestedMinimumWidth9930;
		protected virtual int getSuggestedMinimumWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.View._getSuggestedMinimumWidth9930);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._getSuggestedMinimumWidth9930);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumHeight9931;
		public virtual void setMinimumHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setMinimumHeight9931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setMinimumHeight9931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumWidth9932;
		public virtual void setMinimumWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setMinimumWidth9932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setMinimumWidth9932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startAnimation9933;
		public virtual void startAnimation(android.view.animation.Animation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._startAnimation9933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._startAnimation9933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearAnimation9934;
		public virtual void clearAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._clearAnimation9934);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._clearAnimation9934);
		}
		internal static global::MonoJavaBridge.MethodId _setAnimation9935;
		public virtual void setAnimation(android.view.animation.Animation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._setAnimation9935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._setAnimation9935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAnimationStart9936;
		protected virtual void onAnimationStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onAnimationStart9936);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onAnimationStart9936);
		}
		internal static global::MonoJavaBridge.MethodId _onAnimationEnd9937;
		protected virtual void onAnimationEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._onAnimationEnd9937);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onAnimationEnd9937);
		}
		internal static global::MonoJavaBridge.MethodId _onSetAlpha9938;
		protected virtual bool onSetAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._onSetAlpha9938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._onSetAlpha9938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _playSoundEffect9939;
		public virtual void playSoundEffect(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.View._playSoundEffect9939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._playSoundEffect9939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performHapticFeedback9940;
		public virtual bool performHapticFeedback(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._performHapticFeedback9940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._performHapticFeedback9940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performHapticFeedback9941;
		public virtual bool performHapticFeedback(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.View._performHapticFeedback9941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.View.staticClass, global::android.view.View._performHapticFeedback9941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _View9942;
		public View(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.staticClass, global::android.view.View._View9942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _View9943;
		public View(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.staticClass, global::android.view.View._View9943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _View9944;
		public View(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.staticClass, global::android.view.View._View9944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			global::android.view.View._getResources9661 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getResources", "()Landroid/content/res/Resources;");
			global::android.view.View._getParent9662 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getParent", "()Landroid/view/ViewParent;");
			global::android.view.View._getId9663 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getId", "()I");
			global::android.view.View._getContext9664 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.view.View._isOpaque9665 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isOpaque", "()Z");
			global::android.view.View._getHandler9666 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getHandler", "()Landroid/os/Handler;");
			global::android.view.View._inflate9667 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "inflate", "(Landroid/content/Context;ILandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.view.View._getTag9668 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTag", "(I)Ljava/lang/Object;");
			global::android.view.View._getTag9669 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTag", "()Ljava/lang/Object;");
			global::android.view.View._invalidate9670 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "invalidate", "(Landroid/graphics/Rect;)V");
			global::android.view.View._invalidate9671 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "invalidate", "()V");
			global::android.view.View._invalidate9672 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "invalidate", "(IIII)V");
			global::android.view.View._layout9673 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "layout", "(IIII)V");
			global::android.view.View._onConfigurationChanged9674 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.View._isEnabled9675 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isEnabled", "()Z");
			global::android.view.View._setEnabled9676 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setEnabled", "(Z)V");
			global::android.view.View._getContentDescription9677 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getContentDescription", "()Ljava/lang/CharSequence;");
			global::android.view.View._setContentDescription9678 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setContentDescription", "(Ljava/lang/CharSequence;)V");
			global::android.view.View._getAnimation9679 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getAnimation", "()Landroid/view/animation/Animation;");
			global::android.view.View._draw9680 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.view.View._getWidth9681 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getWidth", "()I");
			global::android.view.View._getHeight9682 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getHeight", "()I");
			global::android.view.View._post9683 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "post", "(Ljava/lang/Runnable;)Z");
			global::android.view.View._postDelayed9684 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "postDelayed", "(Ljava/lang/Runnable;J)Z");
			global::android.view.View._removeCallbacks9685 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;)Z");
			global::android.view.View._onRestoreInstanceState9686 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.view.View._onSaveInstanceState9687 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.view.View._findViewById9688 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "findViewById", "(I)Landroid/view/View;");
			global::android.view.View._onKeyDown9689 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onKeyLongPress9690 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onKeyUp9691 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onKeyMultiple9692 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.view.View._onTouchEvent9693 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.View._onTrackballEvent9694 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.View._onWindowFocusChanged9695 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.view.View._hasFocus9696 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "hasFocus", "()Z");
			global::android.view.View._onAttachedToWindow9697 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onAttachedToWindow", "()V");
			global::android.view.View._onDetachedFromWindow9698 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onDetachedFromWindow", "()V");
			global::android.view.View._hasWindowFocus9699 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "hasWindowFocus", "()Z");
			global::android.view.View._dispatchKeyEvent9700 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.View._dispatchTouchEvent9701 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.View._dispatchTrackballEvent9702 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.View._dispatchPopulateAccessibilityEvent9703 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.view.View._onCreateContextMenu9704 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;)V");
			global::android.view.View._setBackgroundDrawable9705 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.View._saveHierarchyState9706 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "saveHierarchyState", "(Landroid/util/SparseArray;)V");
			global::android.view.View._restoreHierarchyState9707 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "restoreHierarchyState", "(Landroid/util/SparseArray;)V");
			global::android.view.View._initializeFadingEdge9708 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "initializeFadingEdge", "(Landroid/content/res/TypedArray;)V");
			global::android.view.View._getVerticalFadingEdgeLength9709 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getVerticalFadingEdgeLength", "()I");
			global::android.view.View._setFadingEdgeLength9710 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setFadingEdgeLength", "(I)V");
			global::android.view.View._getHorizontalFadingEdgeLength9711 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getHorizontalFadingEdgeLength", "()I");
			global::android.view.View._getVerticalScrollbarWidth9712 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getVerticalScrollbarWidth", "()I");
			global::android.view.View._getHorizontalScrollbarHeight9713 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getHorizontalScrollbarHeight", "()I");
			global::android.view.View._initializeScrollbars9714 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "initializeScrollbars", "(Landroid/content/res/TypedArray;)V");
			global::android.view.View._setOnFocusChangeListener9715 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setOnFocusChangeListener", "(Landroid/view/View$OnFocusChangeListener;)V");
			global::android.view.View._getOnFocusChangeListener9716 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getOnFocusChangeListener", "()Landroid/view/View$OnFocusChangeListener;");
			global::android.view.View._setOnClickListener9717 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.view.View._setOnLongClickListener9718 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V");
			global::android.view.View._setOnCreateContextMenuListener9719 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setOnCreateContextMenuListener", "(Landroid/view/View$OnCreateContextMenuListener;)V");
			global::android.view.View._performClick9720 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "performClick", "()Z");
			global::android.view.View._performLongClick9721 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "performLongClick", "()Z");
			global::android.view.View._showContextMenu9722 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "showContextMenu", "()Z");
			global::android.view.View._setOnKeyListener9723 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setOnKeyListener", "(Landroid/view/View$OnKeyListener;)V");
			global::android.view.View._setOnTouchListener9724 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setOnTouchListener", "(Landroid/view/View$OnTouchListener;)V");
			global::android.view.View._requestRectangleOnScreen9725 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestRectangleOnScreen", "(Landroid/graphics/Rect;)Z");
			global::android.view.View._requestRectangleOnScreen9726 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestRectangleOnScreen", "(Landroid/graphics/Rect;Z)Z");
			global::android.view.View._clearFocus9727 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "clearFocus", "()V");
			global::android.view.View._hasFocusable9728 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "hasFocusable", "()Z");
			global::android.view.View._onFocusChanged9729 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.view.View._sendAccessibilityEvent9730 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "sendAccessibilityEvent", "(I)V");
			global::android.view.View._sendAccessibilityEventUnchecked9731 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "sendAccessibilityEventUnchecked", "(Landroid/view/accessibility/AccessibilityEvent;)V");
			global::android.view.View._isFocused9732 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isFocused", "()Z");
			global::android.view.View._findFocus9733 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "findFocus", "()Landroid/view/View;");
			global::android.view.View._setScrollContainer9734 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setScrollContainer", "(Z)V");
			global::android.view.View._getDrawingCacheQuality9735 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawingCacheQuality", "()I");
			global::android.view.View._setDrawingCacheQuality9736 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setDrawingCacheQuality", "(I)V");
			global::android.view.View._getKeepScreenOn9737 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getKeepScreenOn", "()Z");
			global::android.view.View._setKeepScreenOn9738 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setKeepScreenOn", "(Z)V");
			global::android.view.View._getNextFocusLeftId9739 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getNextFocusLeftId", "()I");
			global::android.view.View._setNextFocusLeftId9740 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setNextFocusLeftId", "(I)V");
			global::android.view.View._getNextFocusRightId9741 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getNextFocusRightId", "()I");
			global::android.view.View._setNextFocusRightId9742 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setNextFocusRightId", "(I)V");
			global::android.view.View._getNextFocusUpId9743 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getNextFocusUpId", "()I");
			global::android.view.View._setNextFocusUpId9744 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setNextFocusUpId", "(I)V");
			global::android.view.View._getNextFocusDownId9745 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getNextFocusDownId", "()I");
			global::android.view.View._setNextFocusDownId9746 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setNextFocusDownId", "(I)V");
			global::android.view.View._isShown9747 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isShown", "()Z");
			global::android.view.View._fitSystemWindows9748 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "fitSystemWindows", "(Landroid/graphics/Rect;)Z");
			global::android.view.View._getVisibility9749 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getVisibility", "()I");
			global::android.view.View._setVisibility9750 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setVisibility", "(I)V");
			global::android.view.View._setFocusable9751 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setFocusable", "(Z)V");
			global::android.view.View._setFocusableInTouchMode9752 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setFocusableInTouchMode", "(Z)V");
			global::android.view.View._setSoundEffectsEnabled9753 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setSoundEffectsEnabled", "(Z)V");
			global::android.view.View._isSoundEffectsEnabled9754 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isSoundEffectsEnabled", "()Z");
			global::android.view.View._setHapticFeedbackEnabled9755 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setHapticFeedbackEnabled", "(Z)V");
			global::android.view.View._isHapticFeedbackEnabled9756 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isHapticFeedbackEnabled", "()Z");
			global::android.view.View._setWillNotDraw9757 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setWillNotDraw", "(Z)V");
			global::android.view.View._willNotDraw9758 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "willNotDraw", "()Z");
			global::android.view.View._setWillNotCacheDrawing9759 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setWillNotCacheDrawing", "(Z)V");
			global::android.view.View._willNotCacheDrawing9760 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "willNotCacheDrawing", "()Z");
			global::android.view.View._isClickable9761 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isClickable", "()Z");
			global::android.view.View._setClickable9762 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setClickable", "(Z)V");
			global::android.view.View._isLongClickable9763 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isLongClickable", "()Z");
			global::android.view.View._setLongClickable9764 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setLongClickable", "(Z)V");
			global::android.view.View._setPressed9765 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setPressed", "(Z)V");
			global::android.view.View._dispatchSetPressed9766 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchSetPressed", "(Z)V");
			global::android.view.View._isPressed9767 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isPressed", "()Z");
			global::android.view.View._isSaveEnabled9768 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isSaveEnabled", "()Z");
			global::android.view.View._setSaveEnabled9769 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setSaveEnabled", "(Z)V");
			global::android.view.View._isFocusable9770 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isFocusable", "()Z");
			global::android.view.View._isFocusableInTouchMode9771 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isFocusableInTouchMode", "()Z");
			global::android.view.View._focusSearch9772 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "focusSearch", "(I)Landroid/view/View;");
			global::android.view.View._dispatchUnhandledMove9773 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z");
			global::android.view.View._getFocusables9774 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getFocusables", "(I)Ljava/util/ArrayList;");
			global::android.view.View._addFocusables9775 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "addFocusables", "(Ljava/util/ArrayList;I)V");
			global::android.view.View._addFocusables9776 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "addFocusables", "(Ljava/util/ArrayList;II)V");
			global::android.view.View._getTouchables9777 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTouchables", "()Ljava/util/ArrayList;");
			global::android.view.View._addTouchables9778 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V");
			global::android.view.View._requestFocus9779 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestFocus", "(I)Z");
			global::android.view.View._requestFocus9780 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestFocus", "()Z");
			global::android.view.View._requestFocus9781 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z");
			global::android.view.View._requestFocusFromTouch9782 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestFocusFromTouch", "()Z");
			global::android.view.View._onStartTemporaryDetach9783 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onStartTemporaryDetach", "()V");
			global::android.view.View._onFinishTemporaryDetach9784 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onFinishTemporaryDetach", "()V");
			global::android.view.View._getKeyDispatcherState9785 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;");
			global::android.view.View._dispatchKeyEventPreIme9786 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z");
			global::android.view.View._dispatchKeyShortcutEvent9787 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.View._dispatchWindowFocusChanged9788 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchWindowFocusChanged", "(Z)V");
			global::android.view.View._dispatchVisibilityChanged9789 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchVisibilityChanged", "(Landroid/view/View;I)V");
			global::android.view.View._onVisibilityChanged9790 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onVisibilityChanged", "(Landroid/view/View;I)V");
			global::android.view.View._dispatchDisplayHint9791 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchDisplayHint", "(I)V");
			global::android.view.View._onDisplayHint9792 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onDisplayHint", "(I)V");
			global::android.view.View._dispatchWindowVisibilityChanged9793 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchWindowVisibilityChanged", "(I)V");
			global::android.view.View._onWindowVisibilityChanged9794 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onWindowVisibilityChanged", "(I)V");
			global::android.view.View._getWindowVisibility9795 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getWindowVisibility", "()I");
			global::android.view.View._getWindowVisibleDisplayFrame9796 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getWindowVisibleDisplayFrame", "(Landroid/graphics/Rect;)V");
			global::android.view.View._dispatchConfigurationChanged9797 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.View._isInTouchMode9798 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isInTouchMode", "()Z");
			global::android.view.View._onKeyPreIme9799 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onKeyPreIme", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onKeyShortcut9800 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.View._onCheckIsTextEditor9801 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onCheckIsTextEditor", "()Z");
			global::android.view.View._onCreateInputConnection9802 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.view.View._checkInputConnectionProxy9803 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "checkInputConnectionProxy", "(Landroid/view/View;)Z");
			global::android.view.View._createContextMenu9804 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "createContextMenu", "(Landroid/view/ContextMenu;)V");
			global::android.view.View._getContextMenuInfo9805 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
			global::android.view.View._cancelLongPress9806 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "cancelLongPress", "()V");
			global::android.view.View._setTouchDelegate9807 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setTouchDelegate", "(Landroid/view/TouchDelegate;)V");
			global::android.view.View._getTouchDelegate9808 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTouchDelegate", "()Landroid/view/TouchDelegate;");
			global::android.view.View._bringToFront9809 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "bringToFront", "()V");
			global::android.view.View._onScrollChanged9810 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onScrollChanged", "(IIII)V");
			global::android.view.View._onSizeChanged9811 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onSizeChanged", "(IIII)V");
			global::android.view.View._dispatchDraw9812 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.view.View._getScrollX9813 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getScrollX", "()I");
			global::android.view.View._getScrollY9814 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getScrollY", "()I");
			global::android.view.View._getDrawingRect9815 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawingRect", "(Landroid/graphics/Rect;)V");
			global::android.view.View._getMeasuredWidth9816 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getMeasuredWidth", "()I");
			global::android.view.View._getMeasuredHeight9817 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getMeasuredHeight", "()I");
			global::android.view.View._getTop9818 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTop", "()I");
			global::android.view.View._getBottom9819 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getBottom", "()I");
			global::android.view.View._getLeft9820 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLeft", "()I");
			global::android.view.View._getRight9821 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getRight", "()I");
			global::android.view.View._getHitRect9822 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getHitRect", "(Landroid/graphics/Rect;)V");
			global::android.view.View._getFocusedRect9823 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V");
			global::android.view.View._getGlobalVisibleRect9824 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getGlobalVisibleRect", "(Landroid/graphics/Rect;Landroid/graphics/Point;)Z");
			global::android.view.View._getGlobalVisibleRect9825 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getGlobalVisibleRect", "(Landroid/graphics/Rect;)Z");
			global::android.view.View._getLocalVisibleRect9826 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLocalVisibleRect", "(Landroid/graphics/Rect;)Z");
			global::android.view.View._offsetTopAndBottom9827 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "offsetTopAndBottom", "(I)V");
			global::android.view.View._offsetLeftAndRight9828 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "offsetLeftAndRight", "(I)V");
			global::android.view.View._getLayoutParams9829 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.View._setLayoutParams9830 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.View._scrollTo9831 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "scrollTo", "(II)V");
			global::android.view.View._scrollBy9832 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "scrollBy", "(II)V");
			global::android.view.View._awakenScrollBars9833 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "awakenScrollBars", "(IZ)Z");
			global::android.view.View._awakenScrollBars9834 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "awakenScrollBars", "()Z");
			global::android.view.View._awakenScrollBars9835 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "awakenScrollBars", "(I)Z");
			global::android.view.View._postInvalidate9836 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "postInvalidate", "(IIII)V");
			global::android.view.View._postInvalidate9837 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "postInvalidate", "()V");
			global::android.view.View._postInvalidateDelayed9838 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "postInvalidateDelayed", "(J)V");
			global::android.view.View._postInvalidateDelayed9839 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "postInvalidateDelayed", "(JIIII)V");
			global::android.view.View._computeScroll9840 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeScroll", "()V");
			global::android.view.View._isHorizontalFadingEdgeEnabled9841 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isHorizontalFadingEdgeEnabled", "()Z");
			global::android.view.View._setHorizontalFadingEdgeEnabled9842 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setHorizontalFadingEdgeEnabled", "(Z)V");
			global::android.view.View._isVerticalFadingEdgeEnabled9843 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isVerticalFadingEdgeEnabled", "()Z");
			global::android.view.View._setVerticalFadingEdgeEnabled9844 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setVerticalFadingEdgeEnabled", "(Z)V");
			global::android.view.View._getTopFadingEdgeStrength9845 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTopFadingEdgeStrength", "()F");
			global::android.view.View._getBottomFadingEdgeStrength9846 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getBottomFadingEdgeStrength", "()F");
			global::android.view.View._getLeftFadingEdgeStrength9847 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLeftFadingEdgeStrength", "()F");
			global::android.view.View._getRightFadingEdgeStrength9848 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getRightFadingEdgeStrength", "()F");
			global::android.view.View._isHorizontalScrollBarEnabled9849 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isHorizontalScrollBarEnabled", "()Z");
			global::android.view.View._setHorizontalScrollBarEnabled9850 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setHorizontalScrollBarEnabled", "(Z)V");
			global::android.view.View._isVerticalScrollBarEnabled9851 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isVerticalScrollBarEnabled", "()Z");
			global::android.view.View._setVerticalScrollBarEnabled9852 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setVerticalScrollBarEnabled", "(Z)V");
			global::android.view.View._setScrollbarFadingEnabled9853 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setScrollbarFadingEnabled", "(Z)V");
			global::android.view.View._isScrollbarFadingEnabled9854 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isScrollbarFadingEnabled", "()Z");
			global::android.view.View._setScrollBarStyle9855 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setScrollBarStyle", "(I)V");
			global::android.view.View._getScrollBarStyle9856 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getScrollBarStyle", "()I");
			global::android.view.View._computeHorizontalScrollRange9857 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.view.View._computeHorizontalScrollOffset9858 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeHorizontalScrollOffset", "()I");
			global::android.view.View._computeHorizontalScrollExtent9859 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeHorizontalScrollExtent", "()I");
			global::android.view.View._computeVerticalScrollRange9860 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeVerticalScrollRange", "()I");
			global::android.view.View._computeVerticalScrollOffset9861 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.view.View._computeVerticalScrollExtent9862 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.view.View._onDrawScrollBars9863 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onDrawScrollBars", "(Landroid/graphics/Canvas;)V");
			global::android.view.View._onDraw9864 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.view.View._getWindowAttachCount9865 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getWindowAttachCount", "()I");
			global::android.view.View._getWindowToken9866 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getWindowToken", "()Landroid/os/IBinder;");
			global::android.view.View._getApplicationWindowToken9867 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getApplicationWindowToken", "()Landroid/os/IBinder;");
			global::android.view.View._dispatchSaveInstanceState9868 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.view.View._dispatchRestoreInstanceState9869 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.view.View._getDrawingTime9870 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawingTime", "()J");
			global::android.view.View._setDuplicateParentStateEnabled9871 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setDuplicateParentStateEnabled", "(Z)V");
			global::android.view.View._isDuplicateParentStateEnabled9872 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isDuplicateParentStateEnabled", "()Z");
			global::android.view.View._setDrawingCacheEnabled9873 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setDrawingCacheEnabled", "(Z)V");
			global::android.view.View._isDrawingCacheEnabled9874 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isDrawingCacheEnabled", "()Z");
			global::android.view.View._getDrawingCache9875 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawingCache", "(Z)Landroid/graphics/Bitmap;");
			global::android.view.View._getDrawingCache9876 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawingCache", "()Landroid/graphics/Bitmap;");
			global::android.view.View._destroyDrawingCache9877 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "destroyDrawingCache", "()V");
			global::android.view.View._setDrawingCacheBackgroundColor9878 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setDrawingCacheBackgroundColor", "(I)V");
			global::android.view.View._getDrawingCacheBackgroundColor9879 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawingCacheBackgroundColor", "()I");
			global::android.view.View._buildDrawingCache9880 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "buildDrawingCache", "()V");
			global::android.view.View._buildDrawingCache9881 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "buildDrawingCache", "(Z)V");
			global::android.view.View._isInEditMode9882 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isInEditMode", "()Z");
			global::android.view.View._isPaddingOffsetRequired9883 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isPaddingOffsetRequired", "()Z");
			global::android.view.View._getLeftPaddingOffset9884 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLeftPaddingOffset", "()I");
			global::android.view.View._getRightPaddingOffset9885 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getRightPaddingOffset", "()I");
			global::android.view.View._getTopPaddingOffset9886 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getTopPaddingOffset", "()I");
			global::android.view.View._getBottomPaddingOffset9887 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getBottomPaddingOffset", "()I");
			global::android.view.View._getSolidColor9888 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getSolidColor", "()I");
			global::android.view.View._isLayoutRequested9889 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isLayoutRequested", "()Z");
			global::android.view.View._onLayout9890 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onLayout", "(ZIIII)V");
			global::android.view.View._onFinishInflate9891 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onFinishInflate", "()V");
			global::android.view.View._invalidateDrawable9892 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.View._scheduleDrawable9893 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.view.View._unscheduleDrawable9894 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.view.View._unscheduleDrawable9895 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.View._verifyDrawable9896 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.view.View._drawableStateChanged9897 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "drawableStateChanged", "()V");
			global::android.view.View._refreshDrawableState9898 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "refreshDrawableState", "()V");
			global::android.view.View._getDrawableState9899 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getDrawableState", "()[I");
			global::android.view.View._onCreateDrawableState9900 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.view.View._mergeDrawableStates9901 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "mergeDrawableStates", "([I[I)[I");
			global::android.view.View._setBackgroundColor9902 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setBackgroundColor", "(I)V");
			global::android.view.View._setBackgroundResource9903 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setBackgroundResource", "(I)V");
			global::android.view.View._getBackground9904 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getBackground", "()Landroid/graphics/drawable/Drawable;");
			global::android.view.View._setPadding9905 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setPadding", "(IIII)V");
			global::android.view.View._getPaddingTop9906 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getPaddingTop", "()I");
			global::android.view.View._getPaddingBottom9907 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getPaddingBottom", "()I");
			global::android.view.View._getPaddingLeft9908 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getPaddingLeft", "()I");
			global::android.view.View._getPaddingRight9909 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getPaddingRight", "()I");
			global::android.view.View._setSelected9910 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setSelected", "(Z)V");
			global::android.view.View._dispatchSetSelected9911 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "dispatchSetSelected", "(Z)V");
			global::android.view.View._isSelected9912 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "isSelected", "()Z");
			global::android.view.View._getViewTreeObserver9913 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getViewTreeObserver", "()Landroid/view/ViewTreeObserver;");
			global::android.view.View._getRootView9914 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getRootView", "()Landroid/view/View;");
			global::android.view.View._getLocationOnScreen9915 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLocationOnScreen", "([I)V");
			global::android.view.View._getLocationInWindow9916 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getLocationInWindow", "([I)V");
			global::android.view.View._findViewWithTag9917 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "findViewWithTag", "(Ljava/lang/Object;)Landroid/view/View;");
			global::android.view.View._setId9918 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setId", "(I)V");
			global::android.view.View._setTag9919 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setTag", "(ILjava/lang/Object;)V");
			global::android.view.View._setTag9920 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setTag", "(Ljava/lang/Object;)V");
			global::android.view.View._getBaseline9921 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getBaseline", "()I");
			global::android.view.View._requestLayout9922 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "requestLayout", "()V");
			global::android.view.View._forceLayout9923 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "forceLayout", "()V");
			global::android.view.View._measure9924 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "measure", "(II)V");
			global::android.view.View._onMeasure9925 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onMeasure", "(II)V");
			global::android.view.View._setMeasuredDimension9926 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setMeasuredDimension", "(II)V");
			global::android.view.View._resolveSize9927 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "resolveSize", "(II)I");
			global::android.view.View._getDefaultSize9928 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "getDefaultSize", "(II)I");
			global::android.view.View._getSuggestedMinimumHeight9929 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getSuggestedMinimumHeight", "()I");
			global::android.view.View._getSuggestedMinimumWidth9930 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "getSuggestedMinimumWidth", "()I");
			global::android.view.View._setMinimumHeight9931 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setMinimumHeight", "(I)V");
			global::android.view.View._setMinimumWidth9932 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setMinimumWidth", "(I)V");
			global::android.view.View._startAnimation9933 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "startAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.view.View._clearAnimation9934 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "clearAnimation", "()V");
			global::android.view.View._setAnimation9935 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "setAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.view.View._onAnimationStart9936 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onAnimationStart", "()V");
			global::android.view.View._onAnimationEnd9937 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onAnimationEnd", "()V");
			global::android.view.View._onSetAlpha9938 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "onSetAlpha", "(I)Z");
			global::android.view.View._playSoundEffect9939 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "playSoundEffect", "(I)V");
			global::android.view.View._performHapticFeedback9940 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "performHapticFeedback", "(I)Z");
			global::android.view.View._performHapticFeedback9941 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "performHapticFeedback", "(II)Z");
			global::android.view.View._View9942 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.view.View._View9943 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.view.View._View9944 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
