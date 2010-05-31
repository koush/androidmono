namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class View : java.lang.Object, android.graphics.drawable.Drawable.Callback, android.view.KeyEvent.Callback, android.view.accessibility.AccessibilityEventSource
	{ 
		internal static global::java.lang.Class staticClass; 
		static View() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.View), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.View(@__env); 
			} 
		} 
		protected View(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class BaseSavedState : android.view.AbsSavedState
		{ 
			internal new static global::java.lang.Class staticClass; 
			static BaseSavedState() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.View.BaseSavedState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.View.BaseSavedState(@__env); 
				} 
			} 
			protected BaseSavedState(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _BaseSavedState8096; 
			public BaseSavedState(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.View.BaseSavedState.staticClass, global::android.view.View.BaseSavedState._BaseSavedState8096, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _BaseSavedState8097; 
			public BaseSavedState(android.os.Parcelable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.View.BaseSavedState.staticClass, global::android.view.View.BaseSavedState._BaseSavedState8097, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR8098; 
			public static global::android.os.Parcelable_Creator CREATOR
			{ 
				get 
				{ 
					return default(global::android.os.Parcelable_Creator); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.View.BaseSavedState.staticClass = @__class; 
				global::android.view.View.BaseSavedState._BaseSavedState8096 = @__env.GetMethodID(global::android.view.View.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
				global::android.view.View.BaseSavedState._BaseSavedState8097 = @__env.GetMethodID(global::android.view.View.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class MeasureSpec : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static MeasureSpec() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.View.MeasureSpec), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.View.MeasureSpec(@__env); 
				} 
			} 
			protected MeasureSpec(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _toString8099; 
			public static global::java.lang.String toString(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._toString8099, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getSize8100; 
			public static int getSize(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._getSize8100, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getMode8101; 
			public static int getMode(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._getMode8101, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _makeMeasureSpec8102; 
			public static int makeMeasureSpec(int arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._makeMeasureSpec8102, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _MeasureSpec8103; 
			public MeasureSpec()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._MeasureSpec8103, this); 
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.View.MeasureSpec.staticClass = @__class; 
				global::android.view.View.MeasureSpec._toString8099 = @__env.GetStaticMethodID(global::android.view.View.MeasureSpec.staticClass, "toString", "(I)Ljava/lang/String;"); 
				global::android.view.View.MeasureSpec._getSize8100 = @__env.GetStaticMethodID(global::android.view.View.MeasureSpec.staticClass, "getSize", "(I)I"); 
				global::android.view.View.MeasureSpec._getMode8101 = @__env.GetStaticMethodID(global::android.view.View.MeasureSpec.staticClass, "getMode", "(I)I"); 
				global::android.view.View.MeasureSpec._makeMeasureSpec8102 = @__env.GetStaticMethodID(global::android.view.View.MeasureSpec.staticClass, "makeMeasureSpec", "(II)I"); 
				global::android.view.View.MeasureSpec._MeasureSpec8103 = @__env.GetMethodID(global::android.view.View.MeasureSpec.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnClickListener 
		{ 
			void onClick(android.view.View arg0); 
		} 

		public partial class OnClickListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnClickListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnClickListener : java.lang.Object, OnClickListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnClickListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.View.__OnClickListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.View.__OnClickListener(@__env); 
				} 
			} 
			internal __OnClickListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onClick8104; 
			 void android.view.View.OnClickListener.onClick(android.view.View arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.view.View.__OnClickListener._onClick8104, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.View.__OnClickListener.staticClass, global::android.view.View.__OnClickListener._onClick8104, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.View.__OnClickListener.staticClass = @__class; 
				global::android.view.View.__OnClickListener._onClick8104 = @__env.GetMethodID(global::android.view.View.__OnClickListener.staticClass, "android.view.View.OnClickListener.onClick", "(Landroid/view/View;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnCreateContextMenuListener 
		{ 
			void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2); 
		} 

		public partial class OnCreateContextMenuListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnCreateContextMenuListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnCreateContextMenuListener : java.lang.Object, OnCreateContextMenuListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnCreateContextMenuListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.View.__OnCreateContextMenuListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.View.__OnCreateContextMenuListener(@__env); 
				} 
			} 
			internal __OnCreateContextMenuListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onCreateContextMenu8105; 
			 void android.view.View.OnCreateContextMenuListener.onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.view.View.__OnCreateContextMenuListener._onCreateContextMenu8105, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.View.__OnCreateContextMenuListener.staticClass, global::android.view.View.__OnCreateContextMenuListener._onCreateContextMenu8105, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.View.__OnCreateContextMenuListener.staticClass = @__class; 
				global::android.view.View.__OnCreateContextMenuListener._onCreateContextMenu8105 = @__env.GetMethodID(global::android.view.View.__OnCreateContextMenuListener.staticClass, "android.view.View.OnCreateContextMenuListener.onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnFocusChangeListener 
		{ 
			void onFocusChange(android.view.View arg0, bool arg1); 
		} 

		public partial class OnFocusChangeListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnFocusChangeListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnFocusChangeListener : java.lang.Object, OnFocusChangeListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnFocusChangeListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.View.__OnFocusChangeListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.View.__OnFocusChangeListener(@__env); 
				} 
			} 
			internal __OnFocusChangeListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onFocusChange8106; 
			 void android.view.View.OnFocusChangeListener.onFocusChange(android.view.View arg0, bool arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.view.View.__OnFocusChangeListener._onFocusChange8106, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.View.__OnFocusChangeListener.staticClass, global::android.view.View.__OnFocusChangeListener._onFocusChange8106, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.View.__OnFocusChangeListener.staticClass = @__class; 
				global::android.view.View.__OnFocusChangeListener._onFocusChange8106 = @__env.GetMethodID(global::android.view.View.__OnFocusChangeListener.staticClass, "android.view.View.OnFocusChangeListener.onFocusChange", "(Landroid/view/View;Z)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnKeyListener 
		{ 
			bool onKey(android.view.View arg0, int arg1, android.view.KeyEvent arg2); 
		} 

		public partial class OnKeyListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnKeyListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnKeyListener : java.lang.Object, OnKeyListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnKeyListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.View.__OnKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.View.__OnKeyListener(@__env); 
				} 
			} 
			internal __OnKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onKey8107; 
			 bool android.view.View.OnKeyListener.onKey(android.view.View arg0, int arg1, android.view.KeyEvent arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.view.View.__OnKeyListener._onKey8107, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.__OnKeyListener.staticClass, global::android.view.View.__OnKeyListener._onKey8107, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.View.__OnKeyListener.staticClass = @__class; 
				global::android.view.View.__OnKeyListener._onKey8107 = @__env.GetMethodID(global::android.view.View.__OnKeyListener.staticClass, "android.view.View.OnKeyListener.onKey", "(Landroid/view/View;ILandroid/view/KeyEvent;)Z"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnLongClickListener 
		{ 
			bool onLongClick(android.view.View arg0); 
		} 

		public partial class OnLongClickListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnLongClickListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnLongClickListener : java.lang.Object, OnLongClickListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnLongClickListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.View.__OnLongClickListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.View.__OnLongClickListener(@__env); 
				} 
			} 
			internal __OnLongClickListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onLongClick8108; 
			 bool android.view.View.OnLongClickListener.onLongClick(android.view.View arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.view.View.__OnLongClickListener._onLongClick8108, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.__OnLongClickListener.staticClass, global::android.view.View.__OnLongClickListener._onLongClick8108, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.View.__OnLongClickListener.staticClass = @__class; 
				global::android.view.View.__OnLongClickListener._onLongClick8108 = @__env.GetMethodID(global::android.view.View.__OnLongClickListener.staticClass, "android.view.View.OnLongClickListener.onLongClick", "(Landroid/view/View;)Z"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnTouchListener 
		{ 
			bool onTouch(android.view.View arg0, android.view.MotionEvent arg1); 
		} 

		public partial class OnTouchListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnTouchListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnTouchListener : java.lang.Object, OnTouchListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnTouchListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.View.__OnTouchListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.View.__OnTouchListener(@__env); 
				} 
			} 
			internal __OnTouchListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onTouch8109; 
			 bool android.view.View.OnTouchListener.onTouch(android.view.View arg0, android.view.MotionEvent arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.view.View.__OnTouchListener._onTouch8109, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.__OnTouchListener.staticClass, global::android.view.View.__OnTouchListener._onTouch8109, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.View.__OnTouchListener.staticClass = @__class; 
				global::android.view.View.__OnTouchListener._onTouch8109 = @__env.GetMethodID(global::android.view.View.__OnTouchListener.staticClass, "android.view.View.OnTouchListener.onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResources8110; 
		public virtual global::android.content.res.Resources getResources() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getResources8110)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getResources8110)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParent8111; 
		public virtual global::android.view.ViewParent getParent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ViewParent>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getParent8111)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ViewParent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getParent8111)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getId8112; 
		public virtual int getId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getId8112); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getId8112); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContext8113; 
		public virtual global::android.content.Context getContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getContext8113)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getContext8113)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOpaque8114; 
		public virtual bool isOpaque() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isOpaque8114); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isOpaque8114); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHandler8115; 
		public virtual global::android.os.Handler getHandler() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Handler>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getHandler8115)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Handler>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getHandler8115)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate8116; 
		public static global::android.view.View inflate(android.content.Context arg0, int arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallStaticObjectMethodPtr(android.view.View.staticClass, global::android.view.View._inflate8116, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTag8117; 
		public virtual global::java.lang.Object getTag() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getTag8117)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getTag8117)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTag8118; 
		public virtual global::java.lang.Object getTag(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getTag8118, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getTag8118, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidate8119; 
		public virtual void invalidate(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._invalidate8119, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._invalidate8119, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidate8120; 
		public virtual void invalidate(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._invalidate8120, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._invalidate8120, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidate8121; 
		public virtual void invalidate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._invalidate8121); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._invalidate8121); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _layout8122; 
		public virtual void layout(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._layout8122, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._layout8122, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled8123; 
		public virtual bool isEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isEnabled8123); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isEnabled8123); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled8124; 
		public virtual void setEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setEnabled8124, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setEnabled8124, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentDescription8125; 
		public virtual global::java.lang.CharSequence getContentDescription() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getContentDescription8125)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getContentDescription8125)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentDescription8126; 
		public virtual void setContentDescription(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setContentDescription8126, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setContentDescription8126, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAnimation8127; 
		public virtual global::android.view.animation.Animation getAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getAnimation8127)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getAnimation8127)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw8128; 
		public virtual void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._draw8128, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._draw8128, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWidth8129; 
		public virtual int getWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getWidth8129); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getWidth8129); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeight8130; 
		public virtual int getHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getHeight8130); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getHeight8130); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _post8131; 
		public virtual bool post(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._post8131, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._post8131, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postDelayed8132; 
		public virtual bool postDelayed(java.lang.Runnable arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._postDelayed8132, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._postDelayed8132, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeCallbacks8133; 
		public virtual bool removeCallbacks(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._removeCallbacks8133, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._removeCallbacks8133, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState8134; 
		protected virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._onRestoreInstanceState8134, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onRestoreInstanceState8134, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState8135; 
		protected virtual global::android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._onSaveInstanceState8135)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._onSaveInstanceState8135)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findViewById8136; 
		public virtual global::android.view.View findViewById(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._findViewById8136, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._findViewById8136, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown8137; 
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._onKeyDown8137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onKeyDown8137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyLongPress8138; 
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._onKeyLongPress8138, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onKeyLongPress8138, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp8139; 
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._onKeyUp8139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onKeyUp8139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple8140; 
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._onKeyMultiple8140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onKeyMultiple8140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent8141; 
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._onTouchEvent8141, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onTouchEvent8141, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent8142; 
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._onTrackballEvent8142, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onTrackballEvent8142, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged8143; 
		public virtual void onWindowFocusChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._onWindowFocusChanged8143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onWindowFocusChanged8143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasFocus8144; 
		public virtual bool hasFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._hasFocus8144); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._hasFocus8144); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow8145; 
		protected virtual void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._onAttachedToWindow8145); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onAttachedToWindow8145); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow8146; 
		protected virtual void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._onDetachedFromWindow8146); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onDetachedFromWindow8146); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasWindowFocus8147; 
		public virtual bool hasWindowFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._hasWindowFocus8147); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._hasWindowFocus8147); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent8148; 
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._dispatchKeyEvent8148, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchKeyEvent8148, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTouchEvent8149; 
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._dispatchTouchEvent8149, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchTouchEvent8149, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTrackballEvent8150; 
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._dispatchTrackballEvent8150, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchTrackballEvent8150, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent8151; 
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._dispatchPopulateAccessibilityEvent8151, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchPopulateAccessibilityEvent8151, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateContextMenu8152; 
		protected virtual void onCreateContextMenu(android.view.ContextMenu arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._onCreateContextMenu8152, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onCreateContextMenu8152, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundDrawable8153; 
		public virtual void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setBackgroundDrawable8153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setBackgroundDrawable8153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _saveHierarchyState8154; 
		public virtual void saveHierarchyState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._saveHierarchyState8154, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._saveHierarchyState8154, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restoreHierarchyState8155; 
		public virtual void restoreHierarchyState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._restoreHierarchyState8155, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._restoreHierarchyState8155, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _initializeFadingEdge8156; 
		protected virtual void initializeFadingEdge(android.content.res.TypedArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._initializeFadingEdge8156, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._initializeFadingEdge8156, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVerticalFadingEdgeLength8157; 
		public virtual int getVerticalFadingEdgeLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getVerticalFadingEdgeLength8157); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getVerticalFadingEdgeLength8157); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFadingEdgeLength8158; 
		public virtual void setFadingEdgeLength(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setFadingEdgeLength8158, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setFadingEdgeLength8158, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHorizontalFadingEdgeLength8159; 
		public virtual int getHorizontalFadingEdgeLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getHorizontalFadingEdgeLength8159); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getHorizontalFadingEdgeLength8159); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVerticalScrollbarWidth8160; 
		public virtual int getVerticalScrollbarWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getVerticalScrollbarWidth8160); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getVerticalScrollbarWidth8160); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHorizontalScrollbarHeight8161; 
		protected virtual int getHorizontalScrollbarHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getHorizontalScrollbarHeight8161); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getHorizontalScrollbarHeight8161); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _initializeScrollbars8162; 
		protected virtual void initializeScrollbars(android.content.res.TypedArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._initializeScrollbars8162, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._initializeScrollbars8162, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnFocusChangeListener8163; 
		public virtual void setOnFocusChangeListener(android.view.View.OnFocusChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setOnFocusChangeListener8163, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setOnFocusChangeListener8163, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOnFocusChangeListener8164; 
		public virtual global::android.view.View.OnFocusChangeListener getOnFocusChangeListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.View.OnFocusChangeListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getOnFocusChangeListener8164)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.View.OnFocusChangeListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getOnFocusChangeListener8164)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnClickListener8165; 
		public virtual void setOnClickListener(android.view.View.OnClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setOnClickListener8165, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setOnClickListener8165, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnLongClickListener8166; 
		public virtual void setOnLongClickListener(android.view.View.OnLongClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setOnLongClickListener8166, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setOnLongClickListener8166, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnCreateContextMenuListener8167; 
		public virtual void setOnCreateContextMenuListener(android.view.View.OnCreateContextMenuListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setOnCreateContextMenuListener8167, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setOnCreateContextMenuListener8167, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performClick8168; 
		public virtual bool performClick() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._performClick8168); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._performClick8168); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performLongClick8169; 
		public virtual bool performLongClick() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._performLongClick8169); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._performLongClick8169); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showContextMenu8170; 
		public virtual bool showContextMenu() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._showContextMenu8170); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._showContextMenu8170); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnKeyListener8171; 
		public virtual void setOnKeyListener(android.view.View.OnKeyListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setOnKeyListener8171, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setOnKeyListener8171, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnTouchListener8172; 
		public virtual void setOnTouchListener(android.view.View.OnTouchListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setOnTouchListener8172, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setOnTouchListener8172, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestRectangleOnScreen8173; 
		public virtual bool requestRectangleOnScreen(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._requestRectangleOnScreen8173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._requestRectangleOnScreen8173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestRectangleOnScreen8174; 
		public virtual bool requestRectangleOnScreen(android.graphics.Rect arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._requestRectangleOnScreen8174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._requestRectangleOnScreen8174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearFocus8175; 
		public virtual void clearFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._clearFocus8175); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._clearFocus8175); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasFocusable8176; 
		public virtual bool hasFocusable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._hasFocusable8176); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._hasFocusable8176); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged8177; 
		protected virtual void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._onFocusChanged8177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onFocusChanged8177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendAccessibilityEvent8178; 
		public virtual void sendAccessibilityEvent(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._sendAccessibilityEvent8178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._sendAccessibilityEvent8178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendAccessibilityEventUnchecked8179; 
		public virtual void sendAccessibilityEventUnchecked(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._sendAccessibilityEventUnchecked8179, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._sendAccessibilityEventUnchecked8179, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFocused8180; 
		public virtual bool isFocused() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isFocused8180); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isFocused8180); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findFocus8181; 
		public virtual global::android.view.View findFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._findFocus8181)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._findFocus8181)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScrollContainer8182; 
		public virtual void setScrollContainer(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setScrollContainer8182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setScrollContainer8182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawingCacheQuality8183; 
		public virtual int getDrawingCacheQuality() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getDrawingCacheQuality8183); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getDrawingCacheQuality8183); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDrawingCacheQuality8184; 
		public virtual void setDrawingCacheQuality(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setDrawingCacheQuality8184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setDrawingCacheQuality8184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeepScreenOn8185; 
		public virtual bool getKeepScreenOn() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._getKeepScreenOn8185); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._getKeepScreenOn8185); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setKeepScreenOn8186; 
		public virtual void setKeepScreenOn(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setKeepScreenOn8186, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setKeepScreenOn8186, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNextFocusLeftId8187; 
		public virtual int getNextFocusLeftId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getNextFocusLeftId8187); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getNextFocusLeftId8187); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNextFocusLeftId8188; 
		public virtual void setNextFocusLeftId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setNextFocusLeftId8188, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setNextFocusLeftId8188, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNextFocusRightId8189; 
		public virtual int getNextFocusRightId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getNextFocusRightId8189); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getNextFocusRightId8189); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNextFocusRightId8190; 
		public virtual void setNextFocusRightId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setNextFocusRightId8190, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setNextFocusRightId8190, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNextFocusUpId8191; 
		public virtual int getNextFocusUpId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getNextFocusUpId8191); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getNextFocusUpId8191); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNextFocusUpId8192; 
		public virtual void setNextFocusUpId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setNextFocusUpId8192, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setNextFocusUpId8192, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNextFocusDownId8193; 
		public virtual int getNextFocusDownId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getNextFocusDownId8193); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getNextFocusDownId8193); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNextFocusDownId8194; 
		public virtual void setNextFocusDownId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setNextFocusDownId8194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setNextFocusDownId8194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isShown8195; 
		public virtual bool isShown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isShown8195); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isShown8195); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fitSystemWindows8196; 
		protected virtual bool fitSystemWindows(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._fitSystemWindows8196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._fitSystemWindows8196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVisibility8197; 
		public virtual int getVisibility() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getVisibility8197); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getVisibility8197); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisibility8198; 
		public virtual void setVisibility(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setVisibility8198, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setVisibility8198, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFocusable8199; 
		public virtual void setFocusable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setFocusable8199, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setFocusable8199, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFocusableInTouchMode8200; 
		public virtual void setFocusableInTouchMode(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setFocusableInTouchMode8200, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setFocusableInTouchMode8200, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSoundEffectsEnabled8201; 
		public virtual void setSoundEffectsEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setSoundEffectsEnabled8201, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setSoundEffectsEnabled8201, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSoundEffectsEnabled8202; 
		public virtual bool isSoundEffectsEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isSoundEffectsEnabled8202); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isSoundEffectsEnabled8202); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHapticFeedbackEnabled8203; 
		public virtual void setHapticFeedbackEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setHapticFeedbackEnabled8203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setHapticFeedbackEnabled8203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isHapticFeedbackEnabled8204; 
		public virtual bool isHapticFeedbackEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isHapticFeedbackEnabled8204); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isHapticFeedbackEnabled8204); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWillNotDraw8205; 
		public virtual void setWillNotDraw(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setWillNotDraw8205, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setWillNotDraw8205, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _willNotDraw8206; 
		public virtual bool willNotDraw() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._willNotDraw8206); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._willNotDraw8206); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWillNotCacheDrawing8207; 
		public virtual void setWillNotCacheDrawing(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setWillNotCacheDrawing8207, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setWillNotCacheDrawing8207, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _willNotCacheDrawing8208; 
		public virtual bool willNotCacheDrawing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._willNotCacheDrawing8208); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._willNotCacheDrawing8208); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClickable8209; 
		public virtual bool isClickable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isClickable8209); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isClickable8209); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setClickable8210; 
		public virtual void setClickable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setClickable8210, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setClickable8210, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLongClickable8211; 
		public virtual bool isLongClickable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isLongClickable8211); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isLongClickable8211); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLongClickable8212; 
		public virtual void setLongClickable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setLongClickable8212, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setLongClickable8212, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPressed8213; 
		public virtual void setPressed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setPressed8213, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setPressed8213, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetPressed8214; 
		protected virtual void dispatchSetPressed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._dispatchSetPressed8214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchSetPressed8214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPressed8215; 
		public virtual bool isPressed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isPressed8215); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isPressed8215); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSaveEnabled8216; 
		public virtual bool isSaveEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isSaveEnabled8216); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isSaveEnabled8216); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSaveEnabled8217; 
		public virtual void setSaveEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setSaveEnabled8217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setSaveEnabled8217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFocusable8218; 
		public virtual bool isFocusable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isFocusable8218); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isFocusable8218); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFocusableInTouchMode8219; 
		public virtual bool isFocusableInTouchMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isFocusableInTouchMode8219); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isFocusableInTouchMode8219); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _focusSearch8220; 
		public virtual global::android.view.View focusSearch(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._focusSearch8220, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._focusSearch8220, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchUnhandledMove8221; 
		public virtual bool dispatchUnhandledMove(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._dispatchUnhandledMove8221, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchUnhandledMove8221, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFocusables8222; 
		public virtual global::java.util.ArrayList getFocusables(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getFocusables8222, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getFocusables8222, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addFocusables8223; 
		public virtual void addFocusables(java.util.ArrayList arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._addFocusables8223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._addFocusables8223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addFocusables8224; 
		public virtual void addFocusables(java.util.ArrayList arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._addFocusables8224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._addFocusables8224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTouchables8225; 
		public virtual global::java.util.ArrayList getTouchables() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getTouchables8225)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getTouchables8225)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addTouchables8226; 
		public virtual void addTouchables(java.util.ArrayList arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._addTouchables8226, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._addTouchables8226, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestFocus8227; 
		public virtual bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._requestFocus8227, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._requestFocus8227, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestFocus8228; 
		public virtual bool requestFocus(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._requestFocus8228, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._requestFocus8228, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestFocus8229; 
		public virtual bool requestFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._requestFocus8229); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._requestFocus8229); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestFocusFromTouch8230; 
		public virtual bool requestFocusFromTouch() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._requestFocusFromTouch8230); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._requestFocusFromTouch8230); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStartTemporaryDetach8231; 
		public virtual void onStartTemporaryDetach() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._onStartTemporaryDetach8231); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onStartTemporaryDetach8231); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishTemporaryDetach8232; 
		public virtual void onFinishTemporaryDetach() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._onFinishTemporaryDetach8232); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onFinishTemporaryDetach8232); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyDispatcherState8233; 
		public virtual global::android.view.KeyEvent.DispatcherState getKeyDispatcherState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyEvent.DispatcherState>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getKeyDispatcherState8233)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyEvent.DispatcherState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getKeyDispatcherState8233)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEventPreIme8234; 
		public virtual bool dispatchKeyEventPreIme(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._dispatchKeyEventPreIme8234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchKeyEventPreIme8234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyShortcutEvent8235; 
		public virtual bool dispatchKeyShortcutEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._dispatchKeyShortcutEvent8235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchKeyShortcutEvent8235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchWindowFocusChanged8236; 
		public virtual void dispatchWindowFocusChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._dispatchWindowFocusChanged8236, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchWindowFocusChanged8236, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchWindowVisibilityChanged8237; 
		public virtual void dispatchWindowVisibilityChanged(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._dispatchWindowVisibilityChanged8237, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchWindowVisibilityChanged8237, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowVisibilityChanged8238; 
		protected virtual void onWindowVisibilityChanged(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._onWindowVisibilityChanged8238, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onWindowVisibilityChanged8238, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindowVisibility8239; 
		public virtual int getWindowVisibility() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getWindowVisibility8239); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getWindowVisibility8239); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindowVisibleDisplayFrame8240; 
		public virtual void getWindowVisibleDisplayFrame(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._getWindowVisibleDisplayFrame8240, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._getWindowVisibleDisplayFrame8240, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInTouchMode8241; 
		public virtual bool isInTouchMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isInTouchMode8241); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isInTouchMode8241); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyPreIme8242; 
		public virtual bool onKeyPreIme(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._onKeyPreIme8242, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onKeyPreIme8242, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyShortcut8243; 
		public virtual bool onKeyShortcut(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._onKeyShortcut8243, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onKeyShortcut8243, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCheckIsTextEditor8244; 
		public virtual bool onCheckIsTextEditor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._onCheckIsTextEditor8244); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onCheckIsTextEditor8244); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputConnection8245; 
		public virtual global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._onCreateInputConnection8245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._onCreateInputConnection8245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkInputConnectionProxy8246; 
		public virtual bool checkInputConnectionProxy(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._checkInputConnectionProxy8246, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._checkInputConnectionProxy8246, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createContextMenu8247; 
		public virtual void createContextMenu(android.view.ContextMenu arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._createContextMenu8247, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._createContextMenu8247, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContextMenuInfo8248; 
		protected virtual global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getContextMenuInfo8248)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getContextMenuInfo8248)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancelLongPress8249; 
		public virtual void cancelLongPress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._cancelLongPress8249); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._cancelLongPress8249); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTouchDelegate8250; 
		public virtual void setTouchDelegate(android.view.TouchDelegate arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setTouchDelegate8250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setTouchDelegate8250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTouchDelegate8251; 
		public virtual global::android.view.TouchDelegate getTouchDelegate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.TouchDelegate>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getTouchDelegate8251)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.TouchDelegate>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getTouchDelegate8251)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bringToFront8252; 
		public virtual void bringToFront() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._bringToFront8252); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._bringToFront8252); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onScrollChanged8253; 
		protected virtual void onScrollChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._onScrollChanged8253, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onScrollChanged8253, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged8254; 
		protected virtual void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._onSizeChanged8254, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onSizeChanged8254, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw8255; 
		protected virtual void dispatchDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._dispatchDraw8255, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchDraw8255, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScrollX8256; 
		public virtual int getScrollX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getScrollX8256); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getScrollX8256); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScrollY8257; 
		public virtual int getScrollY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getScrollY8257); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getScrollY8257); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawingRect8258; 
		public virtual void getDrawingRect(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._getDrawingRect8258, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._getDrawingRect8258, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMeasuredWidth8259; 
		public virtual int getMeasuredWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getMeasuredWidth8259); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getMeasuredWidth8259); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMeasuredHeight8260; 
		public virtual int getMeasuredHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getMeasuredHeight8260); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getMeasuredHeight8260); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTop8261; 
		public virtual int getTop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getTop8261); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getTop8261); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBottom8262; 
		public virtual int getBottom() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getBottom8262); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getBottom8262); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLeft8263; 
		public virtual int getLeft() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getLeft8263); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getLeft8263); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRight8264; 
		public virtual int getRight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getRight8264); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getRight8264); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHitRect8265; 
		public virtual void getHitRect(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._getHitRect8265, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._getHitRect8265, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFocusedRect8266; 
		public virtual void getFocusedRect(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._getFocusedRect8266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._getFocusedRect8266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalVisibleRect8267; 
		public virtual bool getGlobalVisibleRect(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._getGlobalVisibleRect8267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._getGlobalVisibleRect8267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalVisibleRect8268; 
		public virtual bool getGlobalVisibleRect(android.graphics.Rect arg0, android.graphics.Point arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._getGlobalVisibleRect8268, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._getGlobalVisibleRect8268, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalVisibleRect8269; 
		public virtual bool getLocalVisibleRect(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._getLocalVisibleRect8269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._getLocalVisibleRect8269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offsetTopAndBottom8270; 
		public virtual void offsetTopAndBottom(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._offsetTopAndBottom8270, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._offsetTopAndBottom8270, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offsetLeftAndRight8271; 
		public virtual void offsetLeftAndRight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._offsetLeftAndRight8271, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._offsetLeftAndRight8271, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutParams8272; 
		public virtual global::android.view.ViewGroup.LayoutParams getLayoutParams() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getLayoutParams8272)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getLayoutParams8272)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutParams8273; 
		public virtual void setLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setLayoutParams8273, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setLayoutParams8273, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scrollTo8274; 
		public virtual void scrollTo(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._scrollTo8274, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._scrollTo8274, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scrollBy8275; 
		public virtual void scrollBy(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._scrollBy8275, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._scrollBy8275, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _awakenScrollBars8276; 
		protected virtual bool awakenScrollBars(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._awakenScrollBars8276, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._awakenScrollBars8276, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _awakenScrollBars8277; 
		protected virtual bool awakenScrollBars() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._awakenScrollBars8277); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._awakenScrollBars8277); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _awakenScrollBars8278; 
		protected virtual bool awakenScrollBars(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._awakenScrollBars8278, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._awakenScrollBars8278, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postInvalidate8279; 
		public virtual void postInvalidate(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._postInvalidate8279, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._postInvalidate8279, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postInvalidate8280; 
		public virtual void postInvalidate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._postInvalidate8280); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._postInvalidate8280); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postInvalidateDelayed8281; 
		public virtual void postInvalidateDelayed(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._postInvalidateDelayed8281, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._postInvalidateDelayed8281, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postInvalidateDelayed8282; 
		public virtual void postInvalidateDelayed(long arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._postInvalidateDelayed8282, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._postInvalidateDelayed8282, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeScroll8283; 
		public virtual void computeScroll() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._computeScroll8283); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._computeScroll8283); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isHorizontalFadingEdgeEnabled8284; 
		public virtual bool isHorizontalFadingEdgeEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isHorizontalFadingEdgeEnabled8284); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isHorizontalFadingEdgeEnabled8284); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalFadingEdgeEnabled8285; 
		public virtual void setHorizontalFadingEdgeEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setHorizontalFadingEdgeEnabled8285, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setHorizontalFadingEdgeEnabled8285, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isVerticalFadingEdgeEnabled8286; 
		public virtual bool isVerticalFadingEdgeEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isVerticalFadingEdgeEnabled8286); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isVerticalFadingEdgeEnabled8286); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalFadingEdgeEnabled8287; 
		public virtual void setVerticalFadingEdgeEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setVerticalFadingEdgeEnabled8287, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setVerticalFadingEdgeEnabled8287, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTopFadingEdgeStrength8288; 
		protected virtual float getTopFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.view.View._getTopFadingEdgeStrength8288); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.View.staticClass, global::android.view.View._getTopFadingEdgeStrength8288); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBottomFadingEdgeStrength8289; 
		protected virtual float getBottomFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.view.View._getBottomFadingEdgeStrength8289); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.View.staticClass, global::android.view.View._getBottomFadingEdgeStrength8289); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLeftFadingEdgeStrength8290; 
		protected virtual float getLeftFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.view.View._getLeftFadingEdgeStrength8290); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.View.staticClass, global::android.view.View._getLeftFadingEdgeStrength8290); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRightFadingEdgeStrength8291; 
		protected virtual float getRightFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.view.View._getRightFadingEdgeStrength8291); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.View.staticClass, global::android.view.View._getRightFadingEdgeStrength8291); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isHorizontalScrollBarEnabled8292; 
		public virtual bool isHorizontalScrollBarEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isHorizontalScrollBarEnabled8292); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isHorizontalScrollBarEnabled8292); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalScrollBarEnabled8293; 
		public virtual void setHorizontalScrollBarEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setHorizontalScrollBarEnabled8293, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setHorizontalScrollBarEnabled8293, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isVerticalScrollBarEnabled8294; 
		public virtual bool isVerticalScrollBarEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isVerticalScrollBarEnabled8294); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isVerticalScrollBarEnabled8294); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalScrollBarEnabled8295; 
		public virtual void setVerticalScrollBarEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setVerticalScrollBarEnabled8295, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setVerticalScrollBarEnabled8295, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScrollbarFadingEnabled8296; 
		public virtual void setScrollbarFadingEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setScrollbarFadingEnabled8296, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setScrollbarFadingEnabled8296, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isScrollbarFadingEnabled8297; 
		public virtual bool isScrollbarFadingEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isScrollbarFadingEnabled8297); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isScrollbarFadingEnabled8297); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScrollBarStyle8298; 
		public virtual void setScrollBarStyle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setScrollBarStyle8298, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setScrollBarStyle8298, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScrollBarStyle8299; 
		public virtual int getScrollBarStyle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getScrollBarStyle8299); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getScrollBarStyle8299); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollRange8300; 
		protected virtual int computeHorizontalScrollRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._computeHorizontalScrollRange8300); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._computeHorizontalScrollRange8300); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollOffset8301; 
		protected virtual int computeHorizontalScrollOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._computeHorizontalScrollOffset8301); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._computeHorizontalScrollOffset8301); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollExtent8302; 
		protected virtual int computeHorizontalScrollExtent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._computeHorizontalScrollExtent8302); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._computeHorizontalScrollExtent8302); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollRange8303; 
		protected virtual int computeVerticalScrollRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._computeVerticalScrollRange8303); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._computeVerticalScrollRange8303); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollOffset8304; 
		protected virtual int computeVerticalScrollOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._computeVerticalScrollOffset8304); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._computeVerticalScrollOffset8304); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollExtent8305; 
		protected virtual int computeVerticalScrollExtent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._computeVerticalScrollExtent8305); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._computeVerticalScrollExtent8305); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDrawScrollBars8306; 
		protected virtual void onDrawScrollBars(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._onDrawScrollBars8306, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onDrawScrollBars8306, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDraw8307; 
		protected virtual void onDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._onDraw8307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onDraw8307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindowAttachCount8308; 
		protected virtual int getWindowAttachCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getWindowAttachCount8308); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getWindowAttachCount8308); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindowToken8309; 
		public virtual global::android.os.IBinder getWindowToken() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getWindowToken8309)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getWindowToken8309)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationWindowToken8310; 
		public virtual global::android.os.IBinder getApplicationWindowToken() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getApplicationWindowToken8310)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getApplicationWindowToken8310)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSaveInstanceState8311; 
		protected virtual void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._dispatchSaveInstanceState8311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchSaveInstanceState8311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchRestoreInstanceState8312; 
		protected virtual void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._dispatchRestoreInstanceState8312, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchRestoreInstanceState8312, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawingTime8313; 
		public virtual long getDrawingTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::android.view.View._getDrawingTime8313); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.view.View.staticClass, global::android.view.View._getDrawingTime8313); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDuplicateParentStateEnabled8314; 
		public virtual void setDuplicateParentStateEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setDuplicateParentStateEnabled8314, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setDuplicateParentStateEnabled8314, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDuplicateParentStateEnabled8315; 
		public virtual bool isDuplicateParentStateEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isDuplicateParentStateEnabled8315); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isDuplicateParentStateEnabled8315); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDrawingCacheEnabled8316; 
		public virtual void setDrawingCacheEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setDrawingCacheEnabled8316, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setDrawingCacheEnabled8316, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDrawingCacheEnabled8317; 
		public virtual bool isDrawingCacheEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isDrawingCacheEnabled8317); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isDrawingCacheEnabled8317); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawingCache8318; 
		public virtual global::android.graphics.Bitmap getDrawingCache(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getDrawingCache8318, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getDrawingCache8318, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawingCache8319; 
		public virtual global::android.graphics.Bitmap getDrawingCache() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getDrawingCache8319)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getDrawingCache8319)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _destroyDrawingCache8320; 
		public virtual void destroyDrawingCache() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._destroyDrawingCache8320); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._destroyDrawingCache8320); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDrawingCacheBackgroundColor8321; 
		public virtual void setDrawingCacheBackgroundColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setDrawingCacheBackgroundColor8321, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setDrawingCacheBackgroundColor8321, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawingCacheBackgroundColor8322; 
		public virtual int getDrawingCacheBackgroundColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getDrawingCacheBackgroundColor8322); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getDrawingCacheBackgroundColor8322); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _buildDrawingCache8323; 
		public virtual void buildDrawingCache() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._buildDrawingCache8323); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._buildDrawingCache8323); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _buildDrawingCache8324; 
		public virtual void buildDrawingCache(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._buildDrawingCache8324, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._buildDrawingCache8324, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInEditMode8325; 
		public virtual bool isInEditMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isInEditMode8325); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isInEditMode8325); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPaddingOffsetRequired8326; 
		protected virtual bool isPaddingOffsetRequired() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isPaddingOffsetRequired8326); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isPaddingOffsetRequired8326); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLeftPaddingOffset8327; 
		protected virtual int getLeftPaddingOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getLeftPaddingOffset8327); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getLeftPaddingOffset8327); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRightPaddingOffset8328; 
		protected virtual int getRightPaddingOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getRightPaddingOffset8328); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getRightPaddingOffset8328); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTopPaddingOffset8329; 
		protected virtual int getTopPaddingOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getTopPaddingOffset8329); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getTopPaddingOffset8329); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBottomPaddingOffset8330; 
		protected virtual int getBottomPaddingOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getBottomPaddingOffset8330); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getBottomPaddingOffset8330); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSolidColor8331; 
		public virtual int getSolidColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getSolidColor8331); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getSolidColor8331); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLayoutRequested8332; 
		public virtual bool isLayoutRequested() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isLayoutRequested8332); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isLayoutRequested8332); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout8333; 
		protected virtual void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._onLayout8333, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onLayout8333, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate8334; 
		protected virtual void onFinishInflate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._onFinishInflate8334); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onFinishInflate8334); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable8335; 
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._invalidateDrawable8335, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._invalidateDrawable8335, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable8336; 
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._scheduleDrawable8336, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._scheduleDrawable8336, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable8337; 
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._unscheduleDrawable8337, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._unscheduleDrawable8337, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable8338; 
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._unscheduleDrawable8338, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._unscheduleDrawable8338, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable8339; 
		protected virtual bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._verifyDrawable8339, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._verifyDrawable8339, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged8340; 
		protected virtual void drawableStateChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._drawableStateChanged8340); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._drawableStateChanged8340); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _refreshDrawableState8341; 
		public virtual void refreshDrawableState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._refreshDrawableState8341); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._refreshDrawableState8341); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawableState8342; 
		public virtual int[] getDrawableState() 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getDrawableState8342)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getDrawableState8342)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDrawableState8343; 
		protected virtual int[] onCreateDrawableState(int arg0) 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._onCreateDrawableState8343, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._onCreateDrawableState8343, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mergeDrawableStates8344; 
		protected static int[] mergeDrawableStates(int[] arg0, int[] arg1) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.view.View.staticClass, global::android.view.View._mergeDrawableStates8344, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundColor8345; 
		public virtual void setBackgroundColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setBackgroundColor8345, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setBackgroundColor8345, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundResource8346; 
		public virtual void setBackgroundResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setBackgroundResource8346, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setBackgroundResource8346, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBackground8347; 
		public virtual global::android.graphics.drawable.Drawable getBackground() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getBackground8347)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getBackground8347)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPadding8348; 
		public virtual void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setPadding8348, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setPadding8348, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPaddingTop8349; 
		public virtual int getPaddingTop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getPaddingTop8349); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getPaddingTop8349); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPaddingBottom8350; 
		public virtual int getPaddingBottom() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getPaddingBottom8350); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getPaddingBottom8350); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPaddingLeft8351; 
		public virtual int getPaddingLeft() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getPaddingLeft8351); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getPaddingLeft8351); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPaddingRight8352; 
		public virtual int getPaddingRight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getPaddingRight8352); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getPaddingRight8352); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelected8353; 
		public virtual void setSelected(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setSelected8353, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setSelected8353, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetSelected8354; 
		protected virtual void dispatchSetSelected(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._dispatchSetSelected8354, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._dispatchSetSelected8354, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSelected8355; 
		public virtual bool isSelected() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._isSelected8355); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._isSelected8355); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getViewTreeObserver8356; 
		public virtual global::android.view.ViewTreeObserver getViewTreeObserver() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewTreeObserver>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getViewTreeObserver8356)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewTreeObserver>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getViewTreeObserver8356)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRootView8357; 
		public virtual global::android.view.View getRootView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._getRootView8357)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._getRootView8357)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocationOnScreen8358; 
		public virtual void getLocationOnScreen(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._getLocationOnScreen8358, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._getLocationOnScreen8358, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocationInWindow8359; 
		public virtual void getLocationInWindow(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._getLocationInWindow8359, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._getLocationInWindow8359, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findViewWithTag8360; 
		public virtual global::android.view.View findViewWithTag(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.View._findViewWithTag8360, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.View.staticClass, global::android.view.View._findViewWithTag8360, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setId8361; 
		public virtual void setId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setId8361, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setId8361, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTag8362; 
		public virtual void setTag(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setTag8362, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setTag8362, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTag8363; 
		public virtual void setTag(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setTag8363, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setTag8363, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline8364; 
		public virtual int getBaseline() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getBaseline8364); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getBaseline8364); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout8365; 
		public virtual void requestLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._requestLayout8365); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._requestLayout8365); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _forceLayout8366; 
		public virtual void forceLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._forceLayout8366); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._forceLayout8366); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measure8367; 
		public virtual void measure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._measure8367, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._measure8367, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure8368; 
		protected virtual void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._onMeasure8368, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onMeasure8368, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMeasuredDimension8369; 
		protected virtual void setMeasuredDimension(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setMeasuredDimension8369, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setMeasuredDimension8369, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resolveSize8370; 
		public static int resolveSize(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.View.staticClass, global::android.view.View._resolveSize8370, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultSize8371; 
		public static int getDefaultSize(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.View.staticClass, global::android.view.View._getDefaultSize8371, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSuggestedMinimumHeight8372; 
		protected virtual int getSuggestedMinimumHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getSuggestedMinimumHeight8372); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getSuggestedMinimumHeight8372); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSuggestedMinimumWidth8373; 
		protected virtual int getSuggestedMinimumWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.View._getSuggestedMinimumWidth8373); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.View.staticClass, global::android.view.View._getSuggestedMinimumWidth8373); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinimumHeight8374; 
		public virtual void setMinimumHeight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setMinimumHeight8374, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setMinimumHeight8374, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinimumWidth8375; 
		public virtual void setMinimumWidth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setMinimumWidth8375, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setMinimumWidth8375, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startAnimation8376; 
		public virtual void startAnimation(android.view.animation.Animation arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._startAnimation8376, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._startAnimation8376, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearAnimation8377; 
		public virtual void clearAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._clearAnimation8377); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._clearAnimation8377); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAnimation8378; 
		public virtual void setAnimation(android.view.animation.Animation arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._setAnimation8378, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._setAnimation8378, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAnimationStart8379; 
		protected virtual void onAnimationStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._onAnimationStart8379); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onAnimationStart8379); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAnimationEnd8380; 
		protected virtual void onAnimationEnd() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._onAnimationEnd8380); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._onAnimationEnd8380); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSetAlpha8381; 
		protected virtual bool onSetAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._onSetAlpha8381, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._onSetAlpha8381, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _playSoundEffect8382; 
		public virtual void playSoundEffect(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.View._playSoundEffect8382, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.View.staticClass, global::android.view.View._playSoundEffect8382, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performHapticFeedback8383; 
		public virtual bool performHapticFeedback(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._performHapticFeedback8383, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._performHapticFeedback8383, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performHapticFeedback8384; 
		public virtual bool performHapticFeedback(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.View._performHapticFeedback8384, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.View.staticClass, global::android.view.View._performHapticFeedback8384, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _View8385; 
		public View(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.View.staticClass, global::android.view.View._View8385, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _View8386; 
		public View(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.View.staticClass, global::android.view.View._View8386, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _View8387; 
		public View(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.View.staticClass, global::android.view.View._View8387, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.View.staticClass = @__class; 
			global::android.view.View._getResources8110 = @__env.GetMethodID(global::android.view.View.staticClass, "getResources", "()Landroid/content/res/Resources;"); 
			global::android.view.View._getParent8111 = @__env.GetMethodID(global::android.view.View.staticClass, "getParent", "()Landroid/view/ViewParent;"); 
			global::android.view.View._getId8112 = @__env.GetMethodID(global::android.view.View.staticClass, "getId", "()I"); 
			global::android.view.View._getContext8113 = @__env.GetMethodID(global::android.view.View.staticClass, "getContext", "()Landroid/content/Context;"); 
			global::android.view.View._isOpaque8114 = @__env.GetMethodID(global::android.view.View.staticClass, "isOpaque", "()Z"); 
			global::android.view.View._getHandler8115 = @__env.GetMethodID(global::android.view.View.staticClass, "getHandler", "()Landroid/os/Handler;"); 
			global::android.view.View._inflate8116 = @__env.GetStaticMethodID(global::android.view.View.staticClass, "inflate", "(Landroid/content/Context;ILandroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.view.View._getTag8117 = @__env.GetMethodID(global::android.view.View.staticClass, "getTag", "()Ljava/lang/Object;"); 
			global::android.view.View._getTag8118 = @__env.GetMethodID(global::android.view.View.staticClass, "getTag", "(I)Ljava/lang/Object;"); 
			global::android.view.View._invalidate8119 = @__env.GetMethodID(global::android.view.View.staticClass, "invalidate", "(Landroid/graphics/Rect;)V"); 
			global::android.view.View._invalidate8120 = @__env.GetMethodID(global::android.view.View.staticClass, "invalidate", "(IIII)V"); 
			global::android.view.View._invalidate8121 = @__env.GetMethodID(global::android.view.View.staticClass, "invalidate", "()V"); 
			global::android.view.View._layout8122 = @__env.GetMethodID(global::android.view.View.staticClass, "layout", "(IIII)V"); 
			global::android.view.View._isEnabled8123 = @__env.GetMethodID(global::android.view.View.staticClass, "isEnabled", "()Z"); 
			global::android.view.View._setEnabled8124 = @__env.GetMethodID(global::android.view.View.staticClass, "setEnabled", "(Z)V"); 
			global::android.view.View._getContentDescription8125 = @__env.GetMethodID(global::android.view.View.staticClass, "getContentDescription", "()Ljava/lang/CharSequence;"); 
			global::android.view.View._setContentDescription8126 = @__env.GetMethodID(global::android.view.View.staticClass, "setContentDescription", "(Ljava/lang/CharSequence;)V"); 
			global::android.view.View._getAnimation8127 = @__env.GetMethodID(global::android.view.View.staticClass, "getAnimation", "()Landroid/view/animation/Animation;"); 
			global::android.view.View._draw8128 = @__env.GetMethodID(global::android.view.View.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.view.View._getWidth8129 = @__env.GetMethodID(global::android.view.View.staticClass, "getWidth", "()I"); 
			global::android.view.View._getHeight8130 = @__env.GetMethodID(global::android.view.View.staticClass, "getHeight", "()I"); 
			global::android.view.View._post8131 = @__env.GetMethodID(global::android.view.View.staticClass, "post", "(Ljava/lang/Runnable;)Z"); 
			global::android.view.View._postDelayed8132 = @__env.GetMethodID(global::android.view.View.staticClass, "postDelayed", "(Ljava/lang/Runnable;J)Z"); 
			global::android.view.View._removeCallbacks8133 = @__env.GetMethodID(global::android.view.View.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;)Z"); 
			global::android.view.View._onRestoreInstanceState8134 = @__env.GetMethodID(global::android.view.View.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.view.View._onSaveInstanceState8135 = @__env.GetMethodID(global::android.view.View.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.view.View._findViewById8136 = @__env.GetMethodID(global::android.view.View.staticClass, "findViewById", "(I)Landroid/view/View;"); 
			global::android.view.View._onKeyDown8137 = @__env.GetMethodID(global::android.view.View.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.view.View._onKeyLongPress8138 = @__env.GetMethodID(global::android.view.View.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.view.View._onKeyUp8139 = @__env.GetMethodID(global::android.view.View.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.view.View._onKeyMultiple8140 = @__env.GetMethodID(global::android.view.View.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z"); 
			global::android.view.View._onTouchEvent8141 = @__env.GetMethodID(global::android.view.View.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.View._onTrackballEvent8142 = @__env.GetMethodID(global::android.view.View.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.View._onWindowFocusChanged8143 = @__env.GetMethodID(global::android.view.View.staticClass, "onWindowFocusChanged", "(Z)V"); 
			global::android.view.View._hasFocus8144 = @__env.GetMethodID(global::android.view.View.staticClass, "hasFocus", "()Z"); 
			global::android.view.View._onAttachedToWindow8145 = @__env.GetMethodID(global::android.view.View.staticClass, "onAttachedToWindow", "()V"); 
			global::android.view.View._onDetachedFromWindow8146 = @__env.GetMethodID(global::android.view.View.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.view.View._hasWindowFocus8147 = @__env.GetMethodID(global::android.view.View.staticClass, "hasWindowFocus", "()Z"); 
			global::android.view.View._dispatchKeyEvent8148 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.view.View._dispatchTouchEvent8149 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.View._dispatchTrackballEvent8150 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.View._dispatchPopulateAccessibilityEvent8151 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z"); 
			global::android.view.View._onCreateContextMenu8152 = @__env.GetMethodID(global::android.view.View.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;)V"); 
			global::android.view.View._setBackgroundDrawable8153 = @__env.GetMethodID(global::android.view.View.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.view.View._saveHierarchyState8154 = @__env.GetMethodID(global::android.view.View.staticClass, "saveHierarchyState", "(Landroid/util/SparseArray;)V"); 
			global::android.view.View._restoreHierarchyState8155 = @__env.GetMethodID(global::android.view.View.staticClass, "restoreHierarchyState", "(Landroid/util/SparseArray;)V"); 
			global::android.view.View._initializeFadingEdge8156 = @__env.GetMethodID(global::android.view.View.staticClass, "initializeFadingEdge", "(Landroid/content/res/TypedArray;)V"); 
			global::android.view.View._getVerticalFadingEdgeLength8157 = @__env.GetMethodID(global::android.view.View.staticClass, "getVerticalFadingEdgeLength", "()I"); 
			global::android.view.View._setFadingEdgeLength8158 = @__env.GetMethodID(global::android.view.View.staticClass, "setFadingEdgeLength", "(I)V"); 
			global::android.view.View._getHorizontalFadingEdgeLength8159 = @__env.GetMethodID(global::android.view.View.staticClass, "getHorizontalFadingEdgeLength", "()I"); 
			global::android.view.View._getVerticalScrollbarWidth8160 = @__env.GetMethodID(global::android.view.View.staticClass, "getVerticalScrollbarWidth", "()I"); 
			global::android.view.View._getHorizontalScrollbarHeight8161 = @__env.GetMethodID(global::android.view.View.staticClass, "getHorizontalScrollbarHeight", "()I"); 
			global::android.view.View._initializeScrollbars8162 = @__env.GetMethodID(global::android.view.View.staticClass, "initializeScrollbars", "(Landroid/content/res/TypedArray;)V"); 
			global::android.view.View._setOnFocusChangeListener8163 = @__env.GetMethodID(global::android.view.View.staticClass, "setOnFocusChangeListener", "(Landroid/view/View$OnFocusChangeListener;)V"); 
			global::android.view.View._getOnFocusChangeListener8164 = @__env.GetMethodID(global::android.view.View.staticClass, "getOnFocusChangeListener", "()Landroid/view/View$OnFocusChangeListener;"); 
			global::android.view.View._setOnClickListener8165 = @__env.GetMethodID(global::android.view.View.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V"); 
			global::android.view.View._setOnLongClickListener8166 = @__env.GetMethodID(global::android.view.View.staticClass, "setOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V"); 
			global::android.view.View._setOnCreateContextMenuListener8167 = @__env.GetMethodID(global::android.view.View.staticClass, "setOnCreateContextMenuListener", "(Landroid/view/View$OnCreateContextMenuListener;)V"); 
			global::android.view.View._performClick8168 = @__env.GetMethodID(global::android.view.View.staticClass, "performClick", "()Z"); 
			global::android.view.View._performLongClick8169 = @__env.GetMethodID(global::android.view.View.staticClass, "performLongClick", "()Z"); 
			global::android.view.View._showContextMenu8170 = @__env.GetMethodID(global::android.view.View.staticClass, "showContextMenu", "()Z"); 
			global::android.view.View._setOnKeyListener8171 = @__env.GetMethodID(global::android.view.View.staticClass, "setOnKeyListener", "(Landroid/view/View$OnKeyListener;)V"); 
			global::android.view.View._setOnTouchListener8172 = @__env.GetMethodID(global::android.view.View.staticClass, "setOnTouchListener", "(Landroid/view/View$OnTouchListener;)V"); 
			global::android.view.View._requestRectangleOnScreen8173 = @__env.GetMethodID(global::android.view.View.staticClass, "requestRectangleOnScreen", "(Landroid/graphics/Rect;)Z"); 
			global::android.view.View._requestRectangleOnScreen8174 = @__env.GetMethodID(global::android.view.View.staticClass, "requestRectangleOnScreen", "(Landroid/graphics/Rect;Z)Z"); 
			global::android.view.View._clearFocus8175 = @__env.GetMethodID(global::android.view.View.staticClass, "clearFocus", "()V"); 
			global::android.view.View._hasFocusable8176 = @__env.GetMethodID(global::android.view.View.staticClass, "hasFocusable", "()Z"); 
			global::android.view.View._onFocusChanged8177 = @__env.GetMethodID(global::android.view.View.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V"); 
			global::android.view.View._sendAccessibilityEvent8178 = @__env.GetMethodID(global::android.view.View.staticClass, "sendAccessibilityEvent", "(I)V"); 
			global::android.view.View._sendAccessibilityEventUnchecked8179 = @__env.GetMethodID(global::android.view.View.staticClass, "sendAccessibilityEventUnchecked", "(Landroid/view/accessibility/AccessibilityEvent;)V"); 
			global::android.view.View._isFocused8180 = @__env.GetMethodID(global::android.view.View.staticClass, "isFocused", "()Z"); 
			global::android.view.View._findFocus8181 = @__env.GetMethodID(global::android.view.View.staticClass, "findFocus", "()Landroid/view/View;"); 
			global::android.view.View._setScrollContainer8182 = @__env.GetMethodID(global::android.view.View.staticClass, "setScrollContainer", "(Z)V"); 
			global::android.view.View._getDrawingCacheQuality8183 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawingCacheQuality", "()I"); 
			global::android.view.View._setDrawingCacheQuality8184 = @__env.GetMethodID(global::android.view.View.staticClass, "setDrawingCacheQuality", "(I)V"); 
			global::android.view.View._getKeepScreenOn8185 = @__env.GetMethodID(global::android.view.View.staticClass, "getKeepScreenOn", "()Z"); 
			global::android.view.View._setKeepScreenOn8186 = @__env.GetMethodID(global::android.view.View.staticClass, "setKeepScreenOn", "(Z)V"); 
			global::android.view.View._getNextFocusLeftId8187 = @__env.GetMethodID(global::android.view.View.staticClass, "getNextFocusLeftId", "()I"); 
			global::android.view.View._setNextFocusLeftId8188 = @__env.GetMethodID(global::android.view.View.staticClass, "setNextFocusLeftId", "(I)V"); 
			global::android.view.View._getNextFocusRightId8189 = @__env.GetMethodID(global::android.view.View.staticClass, "getNextFocusRightId", "()I"); 
			global::android.view.View._setNextFocusRightId8190 = @__env.GetMethodID(global::android.view.View.staticClass, "setNextFocusRightId", "(I)V"); 
			global::android.view.View._getNextFocusUpId8191 = @__env.GetMethodID(global::android.view.View.staticClass, "getNextFocusUpId", "()I"); 
			global::android.view.View._setNextFocusUpId8192 = @__env.GetMethodID(global::android.view.View.staticClass, "setNextFocusUpId", "(I)V"); 
			global::android.view.View._getNextFocusDownId8193 = @__env.GetMethodID(global::android.view.View.staticClass, "getNextFocusDownId", "()I"); 
			global::android.view.View._setNextFocusDownId8194 = @__env.GetMethodID(global::android.view.View.staticClass, "setNextFocusDownId", "(I)V"); 
			global::android.view.View._isShown8195 = @__env.GetMethodID(global::android.view.View.staticClass, "isShown", "()Z"); 
			global::android.view.View._fitSystemWindows8196 = @__env.GetMethodID(global::android.view.View.staticClass, "fitSystemWindows", "(Landroid/graphics/Rect;)Z"); 
			global::android.view.View._getVisibility8197 = @__env.GetMethodID(global::android.view.View.staticClass, "getVisibility", "()I"); 
			global::android.view.View._setVisibility8198 = @__env.GetMethodID(global::android.view.View.staticClass, "setVisibility", "(I)V"); 
			global::android.view.View._setFocusable8199 = @__env.GetMethodID(global::android.view.View.staticClass, "setFocusable", "(Z)V"); 
			global::android.view.View._setFocusableInTouchMode8200 = @__env.GetMethodID(global::android.view.View.staticClass, "setFocusableInTouchMode", "(Z)V"); 
			global::android.view.View._setSoundEffectsEnabled8201 = @__env.GetMethodID(global::android.view.View.staticClass, "setSoundEffectsEnabled", "(Z)V"); 
			global::android.view.View._isSoundEffectsEnabled8202 = @__env.GetMethodID(global::android.view.View.staticClass, "isSoundEffectsEnabled", "()Z"); 
			global::android.view.View._setHapticFeedbackEnabled8203 = @__env.GetMethodID(global::android.view.View.staticClass, "setHapticFeedbackEnabled", "(Z)V"); 
			global::android.view.View._isHapticFeedbackEnabled8204 = @__env.GetMethodID(global::android.view.View.staticClass, "isHapticFeedbackEnabled", "()Z"); 
			global::android.view.View._setWillNotDraw8205 = @__env.GetMethodID(global::android.view.View.staticClass, "setWillNotDraw", "(Z)V"); 
			global::android.view.View._willNotDraw8206 = @__env.GetMethodID(global::android.view.View.staticClass, "willNotDraw", "()Z"); 
			global::android.view.View._setWillNotCacheDrawing8207 = @__env.GetMethodID(global::android.view.View.staticClass, "setWillNotCacheDrawing", "(Z)V"); 
			global::android.view.View._willNotCacheDrawing8208 = @__env.GetMethodID(global::android.view.View.staticClass, "willNotCacheDrawing", "()Z"); 
			global::android.view.View._isClickable8209 = @__env.GetMethodID(global::android.view.View.staticClass, "isClickable", "()Z"); 
			global::android.view.View._setClickable8210 = @__env.GetMethodID(global::android.view.View.staticClass, "setClickable", "(Z)V"); 
			global::android.view.View._isLongClickable8211 = @__env.GetMethodID(global::android.view.View.staticClass, "isLongClickable", "()Z"); 
			global::android.view.View._setLongClickable8212 = @__env.GetMethodID(global::android.view.View.staticClass, "setLongClickable", "(Z)V"); 
			global::android.view.View._setPressed8213 = @__env.GetMethodID(global::android.view.View.staticClass, "setPressed", "(Z)V"); 
			global::android.view.View._dispatchSetPressed8214 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchSetPressed", "(Z)V"); 
			global::android.view.View._isPressed8215 = @__env.GetMethodID(global::android.view.View.staticClass, "isPressed", "()Z"); 
			global::android.view.View._isSaveEnabled8216 = @__env.GetMethodID(global::android.view.View.staticClass, "isSaveEnabled", "()Z"); 
			global::android.view.View._setSaveEnabled8217 = @__env.GetMethodID(global::android.view.View.staticClass, "setSaveEnabled", "(Z)V"); 
			global::android.view.View._isFocusable8218 = @__env.GetMethodID(global::android.view.View.staticClass, "isFocusable", "()Z"); 
			global::android.view.View._isFocusableInTouchMode8219 = @__env.GetMethodID(global::android.view.View.staticClass, "isFocusableInTouchMode", "()Z"); 
			global::android.view.View._focusSearch8220 = @__env.GetMethodID(global::android.view.View.staticClass, "focusSearch", "(I)Landroid/view/View;"); 
			global::android.view.View._dispatchUnhandledMove8221 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z"); 
			global::android.view.View._getFocusables8222 = @__env.GetMethodID(global::android.view.View.staticClass, "getFocusables", "(I)Ljava/util/ArrayList;"); 
			global::android.view.View._addFocusables8223 = @__env.GetMethodID(global::android.view.View.staticClass, "addFocusables", "(Ljava/util/ArrayList;I)V"); 
			global::android.view.View._addFocusables8224 = @__env.GetMethodID(global::android.view.View.staticClass, "addFocusables", "(Ljava/util/ArrayList;II)V"); 
			global::android.view.View._getTouchables8225 = @__env.GetMethodID(global::android.view.View.staticClass, "getTouchables", "()Ljava/util/ArrayList;"); 
			global::android.view.View._addTouchables8226 = @__env.GetMethodID(global::android.view.View.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V"); 
			global::android.view.View._requestFocus8227 = @__env.GetMethodID(global::android.view.View.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z"); 
			global::android.view.View._requestFocus8228 = @__env.GetMethodID(global::android.view.View.staticClass, "requestFocus", "(I)Z"); 
			global::android.view.View._requestFocus8229 = @__env.GetMethodID(global::android.view.View.staticClass, "requestFocus", "()Z"); 
			global::android.view.View._requestFocusFromTouch8230 = @__env.GetMethodID(global::android.view.View.staticClass, "requestFocusFromTouch", "()Z"); 
			global::android.view.View._onStartTemporaryDetach8231 = @__env.GetMethodID(global::android.view.View.staticClass, "onStartTemporaryDetach", "()V"); 
			global::android.view.View._onFinishTemporaryDetach8232 = @__env.GetMethodID(global::android.view.View.staticClass, "onFinishTemporaryDetach", "()V"); 
			global::android.view.View._getKeyDispatcherState8233 = @__env.GetMethodID(global::android.view.View.staticClass, "getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;"); 
			global::android.view.View._dispatchKeyEventPreIme8234 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z"); 
			global::android.view.View._dispatchKeyShortcutEvent8235 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.view.View._dispatchWindowFocusChanged8236 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchWindowFocusChanged", "(Z)V"); 
			global::android.view.View._dispatchWindowVisibilityChanged8237 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchWindowVisibilityChanged", "(I)V"); 
			global::android.view.View._onWindowVisibilityChanged8238 = @__env.GetMethodID(global::android.view.View.staticClass, "onWindowVisibilityChanged", "(I)V"); 
			global::android.view.View._getWindowVisibility8239 = @__env.GetMethodID(global::android.view.View.staticClass, "getWindowVisibility", "()I"); 
			global::android.view.View._getWindowVisibleDisplayFrame8240 = @__env.GetMethodID(global::android.view.View.staticClass, "getWindowVisibleDisplayFrame", "(Landroid/graphics/Rect;)V"); 
			global::android.view.View._isInTouchMode8241 = @__env.GetMethodID(global::android.view.View.staticClass, "isInTouchMode", "()Z"); 
			global::android.view.View._onKeyPreIme8242 = @__env.GetMethodID(global::android.view.View.staticClass, "onKeyPreIme", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.view.View._onKeyShortcut8243 = @__env.GetMethodID(global::android.view.View.staticClass, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.view.View._onCheckIsTextEditor8244 = @__env.GetMethodID(global::android.view.View.staticClass, "onCheckIsTextEditor", "()Z"); 
			global::android.view.View._onCreateInputConnection8245 = @__env.GetMethodID(global::android.view.View.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;"); 
			global::android.view.View._checkInputConnectionProxy8246 = @__env.GetMethodID(global::android.view.View.staticClass, "checkInputConnectionProxy", "(Landroid/view/View;)Z"); 
			global::android.view.View._createContextMenu8247 = @__env.GetMethodID(global::android.view.View.staticClass, "createContextMenu", "(Landroid/view/ContextMenu;)V"); 
			global::android.view.View._getContextMenuInfo8248 = @__env.GetMethodID(global::android.view.View.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;"); 
			global::android.view.View._cancelLongPress8249 = @__env.GetMethodID(global::android.view.View.staticClass, "cancelLongPress", "()V"); 
			global::android.view.View._setTouchDelegate8250 = @__env.GetMethodID(global::android.view.View.staticClass, "setTouchDelegate", "(Landroid/view/TouchDelegate;)V"); 
			global::android.view.View._getTouchDelegate8251 = @__env.GetMethodID(global::android.view.View.staticClass, "getTouchDelegate", "()Landroid/view/TouchDelegate;"); 
			global::android.view.View._bringToFront8252 = @__env.GetMethodID(global::android.view.View.staticClass, "bringToFront", "()V"); 
			global::android.view.View._onScrollChanged8253 = @__env.GetMethodID(global::android.view.View.staticClass, "onScrollChanged", "(IIII)V"); 
			global::android.view.View._onSizeChanged8254 = @__env.GetMethodID(global::android.view.View.staticClass, "onSizeChanged", "(IIII)V"); 
			global::android.view.View._dispatchDraw8255 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.view.View._getScrollX8256 = @__env.GetMethodID(global::android.view.View.staticClass, "getScrollX", "()I"); 
			global::android.view.View._getScrollY8257 = @__env.GetMethodID(global::android.view.View.staticClass, "getScrollY", "()I"); 
			global::android.view.View._getDrawingRect8258 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawingRect", "(Landroid/graphics/Rect;)V"); 
			global::android.view.View._getMeasuredWidth8259 = @__env.GetMethodID(global::android.view.View.staticClass, "getMeasuredWidth", "()I"); 
			global::android.view.View._getMeasuredHeight8260 = @__env.GetMethodID(global::android.view.View.staticClass, "getMeasuredHeight", "()I"); 
			global::android.view.View._getTop8261 = @__env.GetMethodID(global::android.view.View.staticClass, "getTop", "()I"); 
			global::android.view.View._getBottom8262 = @__env.GetMethodID(global::android.view.View.staticClass, "getBottom", "()I"); 
			global::android.view.View._getLeft8263 = @__env.GetMethodID(global::android.view.View.staticClass, "getLeft", "()I"); 
			global::android.view.View._getRight8264 = @__env.GetMethodID(global::android.view.View.staticClass, "getRight", "()I"); 
			global::android.view.View._getHitRect8265 = @__env.GetMethodID(global::android.view.View.staticClass, "getHitRect", "(Landroid/graphics/Rect;)V"); 
			global::android.view.View._getFocusedRect8266 = @__env.GetMethodID(global::android.view.View.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V"); 
			global::android.view.View._getGlobalVisibleRect8267 = @__env.GetMethodID(global::android.view.View.staticClass, "getGlobalVisibleRect", "(Landroid/graphics/Rect;)Z"); 
			global::android.view.View._getGlobalVisibleRect8268 = @__env.GetMethodID(global::android.view.View.staticClass, "getGlobalVisibleRect", "(Landroid/graphics/Rect;Landroid/graphics/Point;)Z"); 
			global::android.view.View._getLocalVisibleRect8269 = @__env.GetMethodID(global::android.view.View.staticClass, "getLocalVisibleRect", "(Landroid/graphics/Rect;)Z"); 
			global::android.view.View._offsetTopAndBottom8270 = @__env.GetMethodID(global::android.view.View.staticClass, "offsetTopAndBottom", "(I)V"); 
			global::android.view.View._offsetLeftAndRight8271 = @__env.GetMethodID(global::android.view.View.staticClass, "offsetLeftAndRight", "(I)V"); 
			global::android.view.View._getLayoutParams8272 = @__env.GetMethodID(global::android.view.View.staticClass, "getLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;"); 
			global::android.view.View._setLayoutParams8273 = @__env.GetMethodID(global::android.view.View.staticClass, "setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.view.View._scrollTo8274 = @__env.GetMethodID(global::android.view.View.staticClass, "scrollTo", "(II)V"); 
			global::android.view.View._scrollBy8275 = @__env.GetMethodID(global::android.view.View.staticClass, "scrollBy", "(II)V"); 
			global::android.view.View._awakenScrollBars8276 = @__env.GetMethodID(global::android.view.View.staticClass, "awakenScrollBars", "(I)Z"); 
			global::android.view.View._awakenScrollBars8277 = @__env.GetMethodID(global::android.view.View.staticClass, "awakenScrollBars", "()Z"); 
			global::android.view.View._awakenScrollBars8278 = @__env.GetMethodID(global::android.view.View.staticClass, "awakenScrollBars", "(IZ)Z"); 
			global::android.view.View._postInvalidate8279 = @__env.GetMethodID(global::android.view.View.staticClass, "postInvalidate", "(IIII)V"); 
			global::android.view.View._postInvalidate8280 = @__env.GetMethodID(global::android.view.View.staticClass, "postInvalidate", "()V"); 
			global::android.view.View._postInvalidateDelayed8281 = @__env.GetMethodID(global::android.view.View.staticClass, "postInvalidateDelayed", "(J)V"); 
			global::android.view.View._postInvalidateDelayed8282 = @__env.GetMethodID(global::android.view.View.staticClass, "postInvalidateDelayed", "(JIIII)V"); 
			global::android.view.View._computeScroll8283 = @__env.GetMethodID(global::android.view.View.staticClass, "computeScroll", "()V"); 
			global::android.view.View._isHorizontalFadingEdgeEnabled8284 = @__env.GetMethodID(global::android.view.View.staticClass, "isHorizontalFadingEdgeEnabled", "()Z"); 
			global::android.view.View._setHorizontalFadingEdgeEnabled8285 = @__env.GetMethodID(global::android.view.View.staticClass, "setHorizontalFadingEdgeEnabled", "(Z)V"); 
			global::android.view.View._isVerticalFadingEdgeEnabled8286 = @__env.GetMethodID(global::android.view.View.staticClass, "isVerticalFadingEdgeEnabled", "()Z"); 
			global::android.view.View._setVerticalFadingEdgeEnabled8287 = @__env.GetMethodID(global::android.view.View.staticClass, "setVerticalFadingEdgeEnabled", "(Z)V"); 
			global::android.view.View._getTopFadingEdgeStrength8288 = @__env.GetMethodID(global::android.view.View.staticClass, "getTopFadingEdgeStrength", "()F"); 
			global::android.view.View._getBottomFadingEdgeStrength8289 = @__env.GetMethodID(global::android.view.View.staticClass, "getBottomFadingEdgeStrength", "()F"); 
			global::android.view.View._getLeftFadingEdgeStrength8290 = @__env.GetMethodID(global::android.view.View.staticClass, "getLeftFadingEdgeStrength", "()F"); 
			global::android.view.View._getRightFadingEdgeStrength8291 = @__env.GetMethodID(global::android.view.View.staticClass, "getRightFadingEdgeStrength", "()F"); 
			global::android.view.View._isHorizontalScrollBarEnabled8292 = @__env.GetMethodID(global::android.view.View.staticClass, "isHorizontalScrollBarEnabled", "()Z"); 
			global::android.view.View._setHorizontalScrollBarEnabled8293 = @__env.GetMethodID(global::android.view.View.staticClass, "setHorizontalScrollBarEnabled", "(Z)V"); 
			global::android.view.View._isVerticalScrollBarEnabled8294 = @__env.GetMethodID(global::android.view.View.staticClass, "isVerticalScrollBarEnabled", "()Z"); 
			global::android.view.View._setVerticalScrollBarEnabled8295 = @__env.GetMethodID(global::android.view.View.staticClass, "setVerticalScrollBarEnabled", "(Z)V"); 
			global::android.view.View._setScrollbarFadingEnabled8296 = @__env.GetMethodID(global::android.view.View.staticClass, "setScrollbarFadingEnabled", "(Z)V"); 
			global::android.view.View._isScrollbarFadingEnabled8297 = @__env.GetMethodID(global::android.view.View.staticClass, "isScrollbarFadingEnabled", "()Z"); 
			global::android.view.View._setScrollBarStyle8298 = @__env.GetMethodID(global::android.view.View.staticClass, "setScrollBarStyle", "(I)V"); 
			global::android.view.View._getScrollBarStyle8299 = @__env.GetMethodID(global::android.view.View.staticClass, "getScrollBarStyle", "()I"); 
			global::android.view.View._computeHorizontalScrollRange8300 = @__env.GetMethodID(global::android.view.View.staticClass, "computeHorizontalScrollRange", "()I"); 
			global::android.view.View._computeHorizontalScrollOffset8301 = @__env.GetMethodID(global::android.view.View.staticClass, "computeHorizontalScrollOffset", "()I"); 
			global::android.view.View._computeHorizontalScrollExtent8302 = @__env.GetMethodID(global::android.view.View.staticClass, "computeHorizontalScrollExtent", "()I"); 
			global::android.view.View._computeVerticalScrollRange8303 = @__env.GetMethodID(global::android.view.View.staticClass, "computeVerticalScrollRange", "()I"); 
			global::android.view.View._computeVerticalScrollOffset8304 = @__env.GetMethodID(global::android.view.View.staticClass, "computeVerticalScrollOffset", "()I"); 
			global::android.view.View._computeVerticalScrollExtent8305 = @__env.GetMethodID(global::android.view.View.staticClass, "computeVerticalScrollExtent", "()I"); 
			global::android.view.View._onDrawScrollBars8306 = @__env.GetMethodID(global::android.view.View.staticClass, "onDrawScrollBars", "(Landroid/graphics/Canvas;)V"); 
			global::android.view.View._onDraw8307 = @__env.GetMethodID(global::android.view.View.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.view.View._getWindowAttachCount8308 = @__env.GetMethodID(global::android.view.View.staticClass, "getWindowAttachCount", "()I"); 
			global::android.view.View._getWindowToken8309 = @__env.GetMethodID(global::android.view.View.staticClass, "getWindowToken", "()Landroid/os/IBinder;"); 
			global::android.view.View._getApplicationWindowToken8310 = @__env.GetMethodID(global::android.view.View.staticClass, "getApplicationWindowToken", "()Landroid/os/IBinder;"); 
			global::android.view.View._dispatchSaveInstanceState8311 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V"); 
			global::android.view.View._dispatchRestoreInstanceState8312 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V"); 
			global::android.view.View._getDrawingTime8313 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawingTime", "()J"); 
			global::android.view.View._setDuplicateParentStateEnabled8314 = @__env.GetMethodID(global::android.view.View.staticClass, "setDuplicateParentStateEnabled", "(Z)V"); 
			global::android.view.View._isDuplicateParentStateEnabled8315 = @__env.GetMethodID(global::android.view.View.staticClass, "isDuplicateParentStateEnabled", "()Z"); 
			global::android.view.View._setDrawingCacheEnabled8316 = @__env.GetMethodID(global::android.view.View.staticClass, "setDrawingCacheEnabled", "(Z)V"); 
			global::android.view.View._isDrawingCacheEnabled8317 = @__env.GetMethodID(global::android.view.View.staticClass, "isDrawingCacheEnabled", "()Z"); 
			global::android.view.View._getDrawingCache8318 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawingCache", "(Z)Landroid/graphics/Bitmap;"); 
			global::android.view.View._getDrawingCache8319 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawingCache", "()Landroid/graphics/Bitmap;"); 
			global::android.view.View._destroyDrawingCache8320 = @__env.GetMethodID(global::android.view.View.staticClass, "destroyDrawingCache", "()V"); 
			global::android.view.View._setDrawingCacheBackgroundColor8321 = @__env.GetMethodID(global::android.view.View.staticClass, "setDrawingCacheBackgroundColor", "(I)V"); 
			global::android.view.View._getDrawingCacheBackgroundColor8322 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawingCacheBackgroundColor", "()I"); 
			global::android.view.View._buildDrawingCache8323 = @__env.GetMethodID(global::android.view.View.staticClass, "buildDrawingCache", "()V"); 
			global::android.view.View._buildDrawingCache8324 = @__env.GetMethodID(global::android.view.View.staticClass, "buildDrawingCache", "(Z)V"); 
			global::android.view.View._isInEditMode8325 = @__env.GetMethodID(global::android.view.View.staticClass, "isInEditMode", "()Z"); 
			global::android.view.View._isPaddingOffsetRequired8326 = @__env.GetMethodID(global::android.view.View.staticClass, "isPaddingOffsetRequired", "()Z"); 
			global::android.view.View._getLeftPaddingOffset8327 = @__env.GetMethodID(global::android.view.View.staticClass, "getLeftPaddingOffset", "()I"); 
			global::android.view.View._getRightPaddingOffset8328 = @__env.GetMethodID(global::android.view.View.staticClass, "getRightPaddingOffset", "()I"); 
			global::android.view.View._getTopPaddingOffset8329 = @__env.GetMethodID(global::android.view.View.staticClass, "getTopPaddingOffset", "()I"); 
			global::android.view.View._getBottomPaddingOffset8330 = @__env.GetMethodID(global::android.view.View.staticClass, "getBottomPaddingOffset", "()I"); 
			global::android.view.View._getSolidColor8331 = @__env.GetMethodID(global::android.view.View.staticClass, "getSolidColor", "()I"); 
			global::android.view.View._isLayoutRequested8332 = @__env.GetMethodID(global::android.view.View.staticClass, "isLayoutRequested", "()Z"); 
			global::android.view.View._onLayout8333 = @__env.GetMethodID(global::android.view.View.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.view.View._onFinishInflate8334 = @__env.GetMethodID(global::android.view.View.staticClass, "onFinishInflate", "()V"); 
			global::android.view.View._invalidateDrawable8335 = @__env.GetMethodID(global::android.view.View.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.view.View._scheduleDrawable8336 = @__env.GetMethodID(global::android.view.View.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V"); 
			global::android.view.View._unscheduleDrawable8337 = @__env.GetMethodID(global::android.view.View.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V"); 
			global::android.view.View._unscheduleDrawable8338 = @__env.GetMethodID(global::android.view.View.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.view.View._verifyDrawable8339 = @__env.GetMethodID(global::android.view.View.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z"); 
			global::android.view.View._drawableStateChanged8340 = @__env.GetMethodID(global::android.view.View.staticClass, "drawableStateChanged", "()V"); 
			global::android.view.View._refreshDrawableState8341 = @__env.GetMethodID(global::android.view.View.staticClass, "refreshDrawableState", "()V"); 
			global::android.view.View._getDrawableState8342 = @__env.GetMethodID(global::android.view.View.staticClass, "getDrawableState", "()[I"); 
			global::android.view.View._onCreateDrawableState8343 = @__env.GetMethodID(global::android.view.View.staticClass, "onCreateDrawableState", "(I)[I"); 
			global::android.view.View._mergeDrawableStates8344 = @__env.GetStaticMethodID(global::android.view.View.staticClass, "mergeDrawableStates", "([I[I)[I"); 
			global::android.view.View._setBackgroundColor8345 = @__env.GetMethodID(global::android.view.View.staticClass, "setBackgroundColor", "(I)V"); 
			global::android.view.View._setBackgroundResource8346 = @__env.GetMethodID(global::android.view.View.staticClass, "setBackgroundResource", "(I)V"); 
			global::android.view.View._getBackground8347 = @__env.GetMethodID(global::android.view.View.staticClass, "getBackground", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.view.View._setPadding8348 = @__env.GetMethodID(global::android.view.View.staticClass, "setPadding", "(IIII)V"); 
			global::android.view.View._getPaddingTop8349 = @__env.GetMethodID(global::android.view.View.staticClass, "getPaddingTop", "()I"); 
			global::android.view.View._getPaddingBottom8350 = @__env.GetMethodID(global::android.view.View.staticClass, "getPaddingBottom", "()I"); 
			global::android.view.View._getPaddingLeft8351 = @__env.GetMethodID(global::android.view.View.staticClass, "getPaddingLeft", "()I"); 
			global::android.view.View._getPaddingRight8352 = @__env.GetMethodID(global::android.view.View.staticClass, "getPaddingRight", "()I"); 
			global::android.view.View._setSelected8353 = @__env.GetMethodID(global::android.view.View.staticClass, "setSelected", "(Z)V"); 
			global::android.view.View._dispatchSetSelected8354 = @__env.GetMethodID(global::android.view.View.staticClass, "dispatchSetSelected", "(Z)V"); 
			global::android.view.View._isSelected8355 = @__env.GetMethodID(global::android.view.View.staticClass, "isSelected", "()Z"); 
			global::android.view.View._getViewTreeObserver8356 = @__env.GetMethodID(global::android.view.View.staticClass, "getViewTreeObserver", "()Landroid/view/ViewTreeObserver;"); 
			global::android.view.View._getRootView8357 = @__env.GetMethodID(global::android.view.View.staticClass, "getRootView", "()Landroid/view/View;"); 
			global::android.view.View._getLocationOnScreen8358 = @__env.GetMethodID(global::android.view.View.staticClass, "getLocationOnScreen", "([I)V"); 
			global::android.view.View._getLocationInWindow8359 = @__env.GetMethodID(global::android.view.View.staticClass, "getLocationInWindow", "([I)V"); 
			global::android.view.View._findViewWithTag8360 = @__env.GetMethodID(global::android.view.View.staticClass, "findViewWithTag", "(Ljava/lang/Object;)Landroid/view/View;"); 
			global::android.view.View._setId8361 = @__env.GetMethodID(global::android.view.View.staticClass, "setId", "(I)V"); 
			global::android.view.View._setTag8362 = @__env.GetMethodID(global::android.view.View.staticClass, "setTag", "(ILjava/lang/Object;)V"); 
			global::android.view.View._setTag8363 = @__env.GetMethodID(global::android.view.View.staticClass, "setTag", "(Ljava/lang/Object;)V"); 
			global::android.view.View._getBaseline8364 = @__env.GetMethodID(global::android.view.View.staticClass, "getBaseline", "()I"); 
			global::android.view.View._requestLayout8365 = @__env.GetMethodID(global::android.view.View.staticClass, "requestLayout", "()V"); 
			global::android.view.View._forceLayout8366 = @__env.GetMethodID(global::android.view.View.staticClass, "forceLayout", "()V"); 
			global::android.view.View._measure8367 = @__env.GetMethodID(global::android.view.View.staticClass, "measure", "(II)V"); 
			global::android.view.View._onMeasure8368 = @__env.GetMethodID(global::android.view.View.staticClass, "onMeasure", "(II)V"); 
			global::android.view.View._setMeasuredDimension8369 = @__env.GetMethodID(global::android.view.View.staticClass, "setMeasuredDimension", "(II)V"); 
			global::android.view.View._resolveSize8370 = @__env.GetStaticMethodID(global::android.view.View.staticClass, "resolveSize", "(II)I"); 
			global::android.view.View._getDefaultSize8371 = @__env.GetStaticMethodID(global::android.view.View.staticClass, "getDefaultSize", "(II)I"); 
			global::android.view.View._getSuggestedMinimumHeight8372 = @__env.GetMethodID(global::android.view.View.staticClass, "getSuggestedMinimumHeight", "()I"); 
			global::android.view.View._getSuggestedMinimumWidth8373 = @__env.GetMethodID(global::android.view.View.staticClass, "getSuggestedMinimumWidth", "()I"); 
			global::android.view.View._setMinimumHeight8374 = @__env.GetMethodID(global::android.view.View.staticClass, "setMinimumHeight", "(I)V"); 
			global::android.view.View._setMinimumWidth8375 = @__env.GetMethodID(global::android.view.View.staticClass, "setMinimumWidth", "(I)V"); 
			global::android.view.View._startAnimation8376 = @__env.GetMethodID(global::android.view.View.staticClass, "startAnimation", "(Landroid/view/animation/Animation;)V"); 
			global::android.view.View._clearAnimation8377 = @__env.GetMethodID(global::android.view.View.staticClass, "clearAnimation", "()V"); 
			global::android.view.View._setAnimation8378 = @__env.GetMethodID(global::android.view.View.staticClass, "setAnimation", "(Landroid/view/animation/Animation;)V"); 
			global::android.view.View._onAnimationStart8379 = @__env.GetMethodID(global::android.view.View.staticClass, "onAnimationStart", "()V"); 
			global::android.view.View._onAnimationEnd8380 = @__env.GetMethodID(global::android.view.View.staticClass, "onAnimationEnd", "()V"); 
			global::android.view.View._onSetAlpha8381 = @__env.GetMethodID(global::android.view.View.staticClass, "onSetAlpha", "(I)Z"); 
			global::android.view.View._playSoundEffect8382 = @__env.GetMethodID(global::android.view.View.staticClass, "playSoundEffect", "(I)V"); 
			global::android.view.View._performHapticFeedback8383 = @__env.GetMethodID(global::android.view.View.staticClass, "performHapticFeedback", "(I)Z"); 
			global::android.view.View._performHapticFeedback8384 = @__env.GetMethodID(global::android.view.View.staticClass, "performHapticFeedback", "(II)Z"); 
			global::android.view.View._View8385 = @__env.GetMethodID(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.view.View._View8386 = @__env.GetMethodID(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.view.View._View8387 = @__env.GetMethodID(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
	public static class ViewExtensionMethods 
	{ 
		public static void setContentDescription(this global::android.view.View __this, string arg0) 
		{ 
			__this.setContentDescription((global::java.lang.String)arg0); 
		} 
	} 
} 
