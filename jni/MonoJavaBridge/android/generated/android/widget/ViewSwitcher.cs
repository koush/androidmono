namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ViewSwitcher : android.widget.ViewAnimator
	{
		internal new static global::java.lang.Class staticClass;
		static ViewSwitcher()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ViewSwitcher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.ViewSwitcher(@__env);
			}
		}
		protected ViewSwitcher(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface ViewFactory 
		{
			global::android.view.View makeView();
		}

		public partial class ViewFactory_
		{
			public static global::java.lang.Class _class
			{
				get { return __ViewFactory.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __ViewFactory : java.lang.Object, ViewFactory
		{
			internal static global::java.lang.Class staticClass;
			static __ViewFactory()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ViewSwitcher.__ViewFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.ViewSwitcher.__ViewFactory(@__env);
				}
			}
			internal __ViewFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _makeView11322;
			 global::android.view.View android.widget.ViewSwitcher.ViewFactory.makeView() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ViewSwitcher.__ViewFactory._makeView11322));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ViewSwitcher.__ViewFactory.staticClass, global::android.widget.ViewSwitcher.__ViewFactory._makeView11322));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.ViewSwitcher.__ViewFactory.staticClass = @__class;
				global::android.widget.ViewSwitcher.__ViewFactory._makeView11322 = @__env.GetMethodID(global::android.widget.ViewSwitcher.__ViewFactory.staticClass, "android.widget.ViewSwitcher.ViewFactory.makeView", "()Landroid/view/View;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset11323;
		public virtual void reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewSwitcher._reset11323);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._reset11323);
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView11324;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewSwitcher._addView11324, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._addView11324, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFactory11325;
		public virtual void setFactory(android.widget.ViewSwitcher.ViewFactory arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewSwitcher._setFactory11325, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._setFactory11325, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNextView11326;
		public virtual global::android.view.View getNextView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ViewSwitcher._getNextView11326));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._getNextView11326));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ViewSwitcher11327;
		public ViewSwitcher(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._ViewSwitcher11327, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ViewSwitcher11328;
		public ViewSwitcher(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._ViewSwitcher11328, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.ViewSwitcher.staticClass = @__class;
			global::android.widget.ViewSwitcher._reset11323 = @__env.GetMethodID(global::android.widget.ViewSwitcher.staticClass, "reset", "()V");
			global::android.widget.ViewSwitcher._addView11324 = @__env.GetMethodID(global::android.widget.ViewSwitcher.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.ViewSwitcher._setFactory11325 = @__env.GetMethodID(global::android.widget.ViewSwitcher.staticClass, "setFactory", "(Landroid/widget/ViewSwitcher$ViewFactory;)V");
			global::android.widget.ViewSwitcher._getNextView11326 = @__env.GetMethodID(global::android.widget.ViewSwitcher.staticClass, "getNextView", "()Landroid/view/View;");
			global::android.widget.ViewSwitcher._ViewSwitcher11327 = @__env.GetMethodID(global::android.widget.ViewSwitcher.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ViewSwitcher._ViewSwitcher11328 = @__env.GetMethodID(global::android.widget.ViewSwitcher.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
