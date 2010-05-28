namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class ViewTreeObserver : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ViewTreeObserver() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewTreeObserver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.ViewTreeObserver(@__env); 
			} 
		} 
		internal ViewTreeObserver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnGlobalFocusChangeListener 
		{ 
			void onGlobalFocusChanged(android.view.View arg0, android.view.View arg1); 
		} 

		public partial class OnGlobalFocusChangeListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnGlobalFocusChangeListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnGlobalFocusChangeListener : java.lang.Object, OnGlobalFocusChangeListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnGlobalFocusChangeListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewTreeObserver.__OnGlobalFocusChangeListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.ViewTreeObserver.__OnGlobalFocusChangeListener(@__env); 
				} 
			} 
			internal __OnGlobalFocusChangeListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onGlobalFocusChanged8644; 
			 void android.view.ViewTreeObserver.OnGlobalFocusChangeListener.onGlobalFocusChanged(android.view.View arg0, android.view.View arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.ViewTreeObserver.__OnGlobalFocusChangeListener)) 
					@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver.__OnGlobalFocusChangeListener._onGlobalFocusChanged8644, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.__OnGlobalFocusChangeListener.staticClass, global::android.view.ViewTreeObserver.__OnGlobalFocusChangeListener._onGlobalFocusChanged8644, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.ViewTreeObserver.__OnGlobalFocusChangeListener.staticClass = @__class; 
				global::android.view.ViewTreeObserver.__OnGlobalFocusChangeListener._onGlobalFocusChanged8644 = @__env.GetMethodID(global::android.view.ViewTreeObserver.__OnGlobalFocusChangeListener.staticClass, "android.view.ViewTreeObserver.OnGlobalFocusChangeListener.onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnGlobalLayoutListener 
		{ 
			void onGlobalLayout(); 
		} 

		public partial class OnGlobalLayoutListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnGlobalLayoutListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnGlobalLayoutListener : java.lang.Object, OnGlobalLayoutListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnGlobalLayoutListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewTreeObserver.__OnGlobalLayoutListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.ViewTreeObserver.__OnGlobalLayoutListener(@__env); 
				} 
			} 
			internal __OnGlobalLayoutListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onGlobalLayout8645; 
			 void android.view.ViewTreeObserver.OnGlobalLayoutListener.onGlobalLayout() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.ViewTreeObserver.__OnGlobalLayoutListener)) 
					@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver.__OnGlobalLayoutListener._onGlobalLayout8645); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.__OnGlobalLayoutListener.staticClass, global::android.view.ViewTreeObserver.__OnGlobalLayoutListener._onGlobalLayout8645); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.ViewTreeObserver.__OnGlobalLayoutListener.staticClass = @__class; 
				global::android.view.ViewTreeObserver.__OnGlobalLayoutListener._onGlobalLayout8645 = @__env.GetMethodID(global::android.view.ViewTreeObserver.__OnGlobalLayoutListener.staticClass, "android.view.ViewTreeObserver.OnGlobalLayoutListener.onGlobalLayout", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnPreDrawListener 
		{ 
			bool onPreDraw(); 
		} 

		public partial class OnPreDrawListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnPreDrawListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnPreDrawListener : java.lang.Object, OnPreDrawListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnPreDrawListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewTreeObserver.__OnPreDrawListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.ViewTreeObserver.__OnPreDrawListener(@__env); 
				} 
			} 
			internal __OnPreDrawListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onPreDraw8646; 
			 bool android.view.ViewTreeObserver.OnPreDrawListener.onPreDraw() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.ViewTreeObserver.__OnPreDrawListener)) 
					return @__env.CallBooleanMethod(this, global::android.view.ViewTreeObserver.__OnPreDrawListener._onPreDraw8646); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewTreeObserver.__OnPreDrawListener.staticClass, global::android.view.ViewTreeObserver.__OnPreDrawListener._onPreDraw8646); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.ViewTreeObserver.__OnPreDrawListener.staticClass = @__class; 
				global::android.view.ViewTreeObserver.__OnPreDrawListener._onPreDraw8646 = @__env.GetMethodID(global::android.view.ViewTreeObserver.__OnPreDrawListener.staticClass, "android.view.ViewTreeObserver.OnPreDrawListener.onPreDraw", "()Z"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnScrollChangedListener 
		{ 
			void onScrollChanged(); 
		} 

		public partial class OnScrollChangedListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnScrollChangedListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnScrollChangedListener : java.lang.Object, OnScrollChangedListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnScrollChangedListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewTreeObserver.__OnScrollChangedListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.ViewTreeObserver.__OnScrollChangedListener(@__env); 
				} 
			} 
			internal __OnScrollChangedListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onScrollChanged8647; 
			 void android.view.ViewTreeObserver.OnScrollChangedListener.onScrollChanged() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.ViewTreeObserver.__OnScrollChangedListener)) 
					@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver.__OnScrollChangedListener._onScrollChanged8647); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.__OnScrollChangedListener.staticClass, global::android.view.ViewTreeObserver.__OnScrollChangedListener._onScrollChanged8647); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.ViewTreeObserver.__OnScrollChangedListener.staticClass = @__class; 
				global::android.view.ViewTreeObserver.__OnScrollChangedListener._onScrollChanged8647 = @__env.GetMethodID(global::android.view.ViewTreeObserver.__OnScrollChangedListener.staticClass, "android.view.ViewTreeObserver.OnScrollChangedListener.onScrollChanged", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnTouchModeChangeListener 
		{ 
			void onTouchModeChanged(bool arg0); 
		} 

		public partial class OnTouchModeChangeListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnTouchModeChangeListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnTouchModeChangeListener : java.lang.Object, OnTouchModeChangeListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnTouchModeChangeListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewTreeObserver.__OnTouchModeChangeListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.ViewTreeObserver.__OnTouchModeChangeListener(@__env); 
				} 
			} 
			internal __OnTouchModeChangeListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onTouchModeChanged8648; 
			 void android.view.ViewTreeObserver.OnTouchModeChangeListener.onTouchModeChanged(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.ViewTreeObserver.__OnTouchModeChangeListener)) 
					@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver.__OnTouchModeChangeListener._onTouchModeChanged8648, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.__OnTouchModeChangeListener.staticClass, global::android.view.ViewTreeObserver.__OnTouchModeChangeListener._onTouchModeChanged8648, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.ViewTreeObserver.__OnTouchModeChangeListener.staticClass = @__class; 
				global::android.view.ViewTreeObserver.__OnTouchModeChangeListener._onTouchModeChanged8648 = @__env.GetMethodID(global::android.view.ViewTreeObserver.__OnTouchModeChangeListener.staticClass, "android.view.ViewTreeObserver.OnTouchModeChangeListener.onTouchModeChanged", "(Z)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAlive8649; 
		public bool isAlive() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewTreeObserver._isAlive8649); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._isAlive8649); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addOnGlobalFocusChangeListener8650; 
		public void addOnGlobalFocusChangeListener(android.view.ViewTreeObserver.OnGlobalFocusChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._addOnGlobalFocusChangeListener8650, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnGlobalFocusChangeListener8650, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeOnGlobalFocusChangeListener8651; 
		public void removeOnGlobalFocusChangeListener(android.view.ViewTreeObserver.OnGlobalFocusChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._removeOnGlobalFocusChangeListener8651, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnGlobalFocusChangeListener8651, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addOnGlobalLayoutListener8652; 
		public void addOnGlobalLayoutListener(android.view.ViewTreeObserver.OnGlobalLayoutListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._addOnGlobalLayoutListener8652, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnGlobalLayoutListener8652, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeGlobalOnLayoutListener8653; 
		public void removeGlobalOnLayoutListener(android.view.ViewTreeObserver.OnGlobalLayoutListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._removeGlobalOnLayoutListener8653, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeGlobalOnLayoutListener8653, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addOnPreDrawListener8654; 
		public void addOnPreDrawListener(android.view.ViewTreeObserver.OnPreDrawListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._addOnPreDrawListener8654, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnPreDrawListener8654, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeOnPreDrawListener8655; 
		public void removeOnPreDrawListener(android.view.ViewTreeObserver.OnPreDrawListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._removeOnPreDrawListener8655, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnPreDrawListener8655, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addOnScrollChangedListener8656; 
		public void addOnScrollChangedListener(android.view.ViewTreeObserver.OnScrollChangedListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._addOnScrollChangedListener8656, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnScrollChangedListener8656, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeOnScrollChangedListener8657; 
		public void removeOnScrollChangedListener(android.view.ViewTreeObserver.OnScrollChangedListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._removeOnScrollChangedListener8657, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnScrollChangedListener8657, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addOnTouchModeChangeListener8658; 
		public void addOnTouchModeChangeListener(android.view.ViewTreeObserver.OnTouchModeChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._addOnTouchModeChangeListener8658, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnTouchModeChangeListener8658, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeOnTouchModeChangeListener8659; 
		public void removeOnTouchModeChangeListener(android.view.ViewTreeObserver.OnTouchModeChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._removeOnTouchModeChangeListener8659, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnTouchModeChangeListener8659, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchOnGlobalLayout8660; 
		public void dispatchOnGlobalLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, global::android.view.ViewTreeObserver._dispatchOnGlobalLayout8660); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._dispatchOnGlobalLayout8660); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchOnPreDraw8661; 
		public bool dispatchOnPreDraw() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewTreeObserver._dispatchOnPreDraw8661); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._dispatchOnPreDraw8661); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.ViewTreeObserver.staticClass = @__class; 
			global::android.view.ViewTreeObserver._isAlive8649 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "isAlive", "()Z"); 
			global::android.view.ViewTreeObserver._addOnGlobalFocusChangeListener8650 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "addOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V"); 
			global::android.view.ViewTreeObserver._removeOnGlobalFocusChangeListener8651 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "removeOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V"); 
			global::android.view.ViewTreeObserver._addOnGlobalLayoutListener8652 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "addOnGlobalLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V"); 
			global::android.view.ViewTreeObserver._removeGlobalOnLayoutListener8653 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "removeGlobalOnLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V"); 
			global::android.view.ViewTreeObserver._addOnPreDrawListener8654 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "addOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V"); 
			global::android.view.ViewTreeObserver._removeOnPreDrawListener8655 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "removeOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V"); 
			global::android.view.ViewTreeObserver._addOnScrollChangedListener8656 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "addOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V"); 
			global::android.view.ViewTreeObserver._removeOnScrollChangedListener8657 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "removeOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V"); 
			global::android.view.ViewTreeObserver._addOnTouchModeChangeListener8658 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "addOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V"); 
			global::android.view.ViewTreeObserver._removeOnTouchModeChangeListener8659 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "removeOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V"); 
			global::android.view.ViewTreeObserver._dispatchOnGlobalLayout8660 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "dispatchOnGlobalLayout", "()V"); 
			global::android.view.ViewTreeObserver._dispatchOnPreDraw8661 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "dispatchOnPreDraw", "()Z"); 
		} 
	} 
} 
