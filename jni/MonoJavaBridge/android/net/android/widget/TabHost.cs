namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TabHost : android.widget.FrameLayout, android.view.ViewTreeObserver.OnTouchModeChangeListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TabHost() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.TabHost), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.TabHost(@__env); 
			} 
		} 
		protected TabHost(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnTabChangeListener 
		{ 
			void onTabChanged(java.lang.String arg0); 
		} 

		public partial class OnTabChangeListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnTabChangeListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnTabChangeListener : java.lang.Object, OnTabChangeListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnTabChangeListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.TabHost.__OnTabChangeListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.TabHost.__OnTabChangeListener(@__env); 
				} 
			} 
			internal __OnTabChangeListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onTabChanged10912; 
			 void android.widget.TabHost.OnTabChangeListener.onTabChanged(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TabHost.__OnTabChangeListener)) 
					@__env.CallVoidMethod(this, global::android.widget.TabHost.__OnTabChangeListener._onTabChanged10912, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabHost.__OnTabChangeListener.staticClass, global::android.widget.TabHost.__OnTabChangeListener._onTabChanged10912, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.TabHost.__OnTabChangeListener.staticClass = @__class; 
				global::android.widget.TabHost.__OnTabChangeListener._onTabChanged10912 = @__env.GetMethodID(global::android.widget.TabHost.__OnTabChangeListener.staticClass, "android.widget.TabHost.OnTabChangeListener.onTabChanged", "(Ljava/lang/String;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface TabContentFactory 
		{ 
			global::android.view.View createTabContent(java.lang.String arg0); 
		} 

		public partial class TabContentFactory_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __TabContentFactory.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __TabContentFactory : java.lang.Object, TabContentFactory
		{ 
			internal static global::java.lang.Class staticClass; 
			static __TabContentFactory() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.TabHost.__TabContentFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.TabHost.__TabContentFactory(@__env); 
				} 
			} 
			internal __TabContentFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _createTabContent10913; 
			 global::android.view.View android.widget.TabHost.TabContentFactory.createTabContent(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TabHost.__TabContentFactory)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TabHost.__TabContentFactory._createTabContent10913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TabHost.__TabContentFactory.staticClass, global::android.widget.TabHost.__TabContentFactory._createTabContent10913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.TabHost.__TabContentFactory.staticClass = @__class; 
				global::android.widget.TabHost.__TabContentFactory._createTabContent10913 = @__env.GetMethodID(global::android.widget.TabHost.__TabContentFactory.staticClass, "android.widget.TabHost.TabContentFactory.createTabContent", "(Ljava/lang/String;)Landroid/view/View;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class TabSpec : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static TabSpec() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.TabHost.TabSpec), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.TabHost.TabSpec(@__env); 
				} 
			} 
			protected TabSpec(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getTag10914; 
			public virtual global::java.lang.String getTag() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TabHost.TabSpec)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TabHost.TabSpec._getTag10914)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._getTag10914)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setIndicator10915; 
			public virtual global::android.widget.TabHost.TabSpec setIndicator(java.lang.CharSequence arg0, android.graphics.drawable.Drawable arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TabHost.TabSpec)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TabHost.TabSpec._setIndicator10915, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setIndicator10915, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setIndicator10916; 
			public virtual global::android.widget.TabHost.TabSpec setIndicator(android.view.View arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TabHost.TabSpec)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TabHost.TabSpec._setIndicator10916, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setIndicator10916, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setIndicator10917; 
			public virtual global::android.widget.TabHost.TabSpec setIndicator(java.lang.CharSequence arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TabHost.TabSpec)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TabHost.TabSpec._setIndicator10917, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setIndicator10917, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setContent10918; 
			public virtual global::android.widget.TabHost.TabSpec setContent(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TabHost.TabSpec)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TabHost.TabSpec._setContent10918, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setContent10918, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setContent10919; 
			public virtual global::android.widget.TabHost.TabSpec setContent(android.widget.TabHost.TabContentFactory arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TabHost.TabSpec)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TabHost.TabSpec._setContent10919, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setContent10919, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setContent10920; 
			public virtual global::android.widget.TabHost.TabSpec setContent(android.content.Intent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TabHost.TabSpec)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TabHost.TabSpec._setContent10920, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setContent10920, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.TabHost.TabSpec.staticClass = @__class; 
				global::android.widget.TabHost.TabSpec._getTag10914 = @__env.GetMethodID(global::android.widget.TabHost.TabSpec.staticClass, "getTag", "()Ljava/lang/String;"); 
				global::android.widget.TabHost.TabSpec._setIndicator10915 = @__env.GetMethodID(global::android.widget.TabHost.TabSpec.staticClass, "setIndicator", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)Landroid/widget/TabHost$TabSpec;"); 
				global::android.widget.TabHost.TabSpec._setIndicator10916 = @__env.GetMethodID(global::android.widget.TabHost.TabSpec.staticClass, "setIndicator", "(Landroid/view/View;)Landroid/widget/TabHost$TabSpec;"); 
				global::android.widget.TabHost.TabSpec._setIndicator10917 = @__env.GetMethodID(global::android.widget.TabHost.TabSpec.staticClass, "setIndicator", "(Ljava/lang/CharSequence;)Landroid/widget/TabHost$TabSpec;"); 
				global::android.widget.TabHost.TabSpec._setContent10918 = @__env.GetMethodID(global::android.widget.TabHost.TabSpec.staticClass, "setContent", "(I)Landroid/widget/TabHost$TabSpec;"); 
				global::android.widget.TabHost.TabSpec._setContent10919 = @__env.GetMethodID(global::android.widget.TabHost.TabSpec.staticClass, "setContent", "(Landroid/widget/TabHost$TabContentFactory;)Landroid/widget/TabHost$TabSpec;"); 
				global::android.widget.TabHost.TabSpec._setContent10920 = @__env.GetMethodID(global::android.widget.TabHost.TabSpec.staticClass, "setContent", "(Landroid/content/Intent;)Landroid/widget/TabHost$TabSpec;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setup10921; 
		public virtual void setup(android.app.LocalActivityManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, global::android.widget.TabHost._setup10921, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setup10921, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setup10922; 
		public virtual void setup() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, global::android.widget.TabHost._setup10922); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setup10922); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow10923; 
		protected override void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, global::android.widget.TabHost._onAttachedToWindow10923); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._onAttachedToWindow10923); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow10924; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, global::android.widget.TabHost._onDetachedFromWindow10924); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._onDetachedFromWindow10924); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent10925; 
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				return @__env.CallBooleanMethod(this, global::android.widget.TabHost._dispatchKeyEvent10925, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._dispatchKeyEvent10925, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchWindowFocusChanged10926; 
		public override void dispatchWindowFocusChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, global::android.widget.TabHost._dispatchWindowFocusChanged10926, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._dispatchWindowFocusChanged10926, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchModeChanged10927; 
		public virtual void onTouchModeChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, global::android.widget.TabHost._onTouchModeChanged10927, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._onTouchModeChanged10927, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTabWidget10928; 
		public virtual global::android.widget.TabWidget getTabWidget() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabWidget>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TabHost._getTabWidget10928)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabWidget>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getTabWidget10928)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newTabSpec10929; 
		public virtual global::android.widget.TabHost.TabSpec newTabSpec(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TabHost._newTabSpec10929, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._newTabSpec10929, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addTab10930; 
		public virtual void addTab(android.widget.TabHost.TabSpec arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, global::android.widget.TabHost._addTab10930, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._addTab10930, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearAllTabs10931; 
		public virtual void clearAllTabs() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, global::android.widget.TabHost._clearAllTabs10931); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._clearAllTabs10931); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentTab10932; 
		public virtual int getCurrentTab() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				return @__env.CallIntMethod(this, global::android.widget.TabHost._getCurrentTab10932); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getCurrentTab10932); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentTabTag10933; 
		public virtual global::java.lang.String getCurrentTabTag() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TabHost._getCurrentTabTag10933)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getCurrentTabTag10933)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentTabView10934; 
		public virtual global::android.view.View getCurrentTabView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TabHost._getCurrentTabView10934)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getCurrentTabView10934)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentView10935; 
		public virtual global::android.view.View getCurrentView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TabHost._getCurrentView10935)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getCurrentView10935)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCurrentTabByTag10936; 
		public virtual void setCurrentTabByTag(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, global::android.widget.TabHost._setCurrentTabByTag10936, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setCurrentTabByTag10936, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTabContentView10937; 
		public virtual global::android.widget.FrameLayout getTabContentView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.FrameLayout>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TabHost._getTabContentView10937)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.FrameLayout>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getTabContentView10937)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCurrentTab10938; 
		public virtual void setCurrentTab(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, global::android.widget.TabHost._setCurrentTab10938, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setCurrentTab10938, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnTabChangedListener10939; 
		public virtual void setOnTabChangedListener(android.widget.TabHost.OnTabChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, global::android.widget.TabHost._setOnTabChangedListener10939, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setOnTabChangedListener10939, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TabHost10940; 
		public TabHost(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TabHost.staticClass, global::android.widget.TabHost._TabHost10940, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TabHost10941; 
		public TabHost(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TabHost.staticClass, global::android.widget.TabHost._TabHost10941, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.TabHost.staticClass = @__class; 
			global::android.widget.TabHost._setup10921 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "setup", "(Landroid/app/LocalActivityManager;)V"); 
			global::android.widget.TabHost._setup10922 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "setup", "()V"); 
			global::android.widget.TabHost._onAttachedToWindow10923 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "onAttachedToWindow", "()V"); 
			global::android.widget.TabHost._onDetachedFromWindow10924 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.widget.TabHost._dispatchKeyEvent10925 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.widget.TabHost._dispatchWindowFocusChanged10926 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "dispatchWindowFocusChanged", "(Z)V"); 
			global::android.widget.TabHost._onTouchModeChanged10927 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "onTouchModeChanged", "(Z)V"); 
			global::android.widget.TabHost._getTabWidget10928 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "getTabWidget", "()Landroid/widget/TabWidget;"); 
			global::android.widget.TabHost._newTabSpec10929 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "newTabSpec", "(Ljava/lang/String;)Landroid/widget/TabHost$TabSpec;"); 
			global::android.widget.TabHost._addTab10930 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "addTab", "(Landroid/widget/TabHost$TabSpec;)V"); 
			global::android.widget.TabHost._clearAllTabs10931 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "clearAllTabs", "()V"); 
			global::android.widget.TabHost._getCurrentTab10932 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "getCurrentTab", "()I"); 
			global::android.widget.TabHost._getCurrentTabTag10933 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "getCurrentTabTag", "()Ljava/lang/String;"); 
			global::android.widget.TabHost._getCurrentTabView10934 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "getCurrentTabView", "()Landroid/view/View;"); 
			global::android.widget.TabHost._getCurrentView10935 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "getCurrentView", "()Landroid/view/View;"); 
			global::android.widget.TabHost._setCurrentTabByTag10936 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "setCurrentTabByTag", "(Ljava/lang/String;)V"); 
			global::android.widget.TabHost._getTabContentView10937 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "getTabContentView", "()Landroid/widget/FrameLayout;"); 
			global::android.widget.TabHost._setCurrentTab10938 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "setCurrentTab", "(I)V"); 
			global::android.widget.TabHost._setOnTabChangedListener10939 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "setOnTabChangedListener", "(Landroid/widget/TabHost$OnTabChangeListener;)V"); 
			global::android.widget.TabHost._TabHost10940 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.TabHost._TabHost10941 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
