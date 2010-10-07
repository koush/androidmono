namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class SimpleCursorTreeAdapter : android.widget.ResourceCursorTreeAdapter
	{
		internal new static global::java.lang.Class staticClass;
		static SimpleCursorTreeAdapter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.SimpleCursorTreeAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected SimpleCursorTreeAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface ViewBinder 
		{
			bool setViewValue(android.view.View arg0, android.database.Cursor arg1, int arg2);
		}

		public partial class ViewBinder_
		{
			public static global::java.lang.Class _class
			{
				get { return __ViewBinder.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __ViewBinder : java.lang.Object, ViewBinder
		{
			internal static global::java.lang.Class staticClass;
			static __ViewBinder()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.SimpleCursorTreeAdapter.__ViewBinder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.SimpleCursorTreeAdapter.__ViewBinder(@__env);
				}
			}
			internal __ViewBinder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _setViewValue11548;
			 bool android.widget.SimpleCursorTreeAdapter.ViewBinder.setViewValue(android.view.View arg0, android.database.Cursor arg1, int arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.widget.SimpleCursorTreeAdapter.__ViewBinder._setViewValue11548, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.SimpleCursorTreeAdapter.__ViewBinder.staticClass, global::android.widget.SimpleCursorTreeAdapter.__ViewBinder._setViewValue11548, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.SimpleCursorTreeAdapter.__ViewBinder.staticClass = @__class;
				global::android.widget.SimpleCursorTreeAdapter.__ViewBinder._setViewValue11548 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.__ViewBinder.staticClass, "android.widget.SimpleCursorTreeAdapter.ViewBinder.setViewValue", "(Landroid/view/View;Landroid/database/Cursor;I)Z");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _bindGroupView11549;
		protected override void bindGroupView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SimpleCursorTreeAdapter._bindGroupView11549, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._bindGroupView11549, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bindChildView11550;
		protected override void bindChildView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SimpleCursorTreeAdapter._bindChildView11550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._bindChildView11550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getViewBinder11551;
		public virtual global::android.widget.SimpleCursorTreeAdapter.ViewBinder getViewBinder() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.SimpleCursorTreeAdapter.ViewBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SimpleCursorTreeAdapter._getViewBinder11551));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.SimpleCursorTreeAdapter.ViewBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._getViewBinder11551));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setViewBinder11552;
		public virtual void setViewBinder(android.widget.SimpleCursorTreeAdapter.ViewBinder arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SimpleCursorTreeAdapter._setViewBinder11552, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._setViewBinder11552, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setViewImage11553;
		protected virtual void setViewImage(android.widget.ImageView arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SimpleCursorTreeAdapter._setViewImage11553, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._setViewImage11553, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setViewText11554;
		public virtual void setViewText(android.widget.TextView arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SimpleCursorTreeAdapter._setViewText11554, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._setViewText11554, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SimpleCursorTreeAdapter11555;
		public SimpleCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, int arg3, java.lang.String[] arg4, int[] arg5, int arg6, java.lang.String[] arg7, int[] arg8)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._SimpleCursorTreeAdapter11555, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg7), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg8));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SimpleCursorTreeAdapter11556;
		public SimpleCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, java.lang.String[] arg3, int[] arg4, int arg5, java.lang.String[] arg6, int[] arg7)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._SimpleCursorTreeAdapter11556, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg6), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg7));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SimpleCursorTreeAdapter11557;
		public SimpleCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, int arg3, java.lang.String[] arg4, int[] arg5, int arg6, int arg7, java.lang.String[] arg8, int[] arg9)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._SimpleCursorTreeAdapter11557, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg8), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg9));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.SimpleCursorTreeAdapter.staticClass = @__class;
			global::android.widget.SimpleCursorTreeAdapter._bindGroupView11549 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.staticClass, "bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
			global::android.widget.SimpleCursorTreeAdapter._bindChildView11550 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.staticClass, "bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
			global::android.widget.SimpleCursorTreeAdapter._getViewBinder11551 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.staticClass, "getViewBinder", "()Landroid/widget/SimpleCursorTreeAdapter$ViewBinder;");
			global::android.widget.SimpleCursorTreeAdapter._setViewBinder11552 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.staticClass, "setViewBinder", "(Landroid/widget/SimpleCursorTreeAdapter$ViewBinder;)V");
			global::android.widget.SimpleCursorTreeAdapter._setViewImage11553 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V");
			global::android.widget.SimpleCursorTreeAdapter._setViewText11554 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.staticClass, "setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V");
			global::android.widget.SimpleCursorTreeAdapter._SimpleCursorTreeAdapter11555 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;II[Ljava/lang/String;[II[Ljava/lang/String;[I)V");
			global::android.widget.SimpleCursorTreeAdapter._SimpleCursorTreeAdapter11556 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;I[Ljava/lang/String;[II[Ljava/lang/String;[I)V");
			global::android.widget.SimpleCursorTreeAdapter._SimpleCursorTreeAdapter11557 = @__env.GetMethodID(global::android.widget.SimpleCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;II[Ljava/lang/String;[III[Ljava/lang/String;[I)V");
		}
	}
}
