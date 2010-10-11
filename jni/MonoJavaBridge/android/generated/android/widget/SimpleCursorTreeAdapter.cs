namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.SimpleCursorTreeAdapter_))]
	public abstract partial class SimpleCursorTreeAdapter : android.widget.ResourceCursorTreeAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SimpleCursorTreeAdapter()
		{
			InitJNI();
		}
		protected SimpleCursorTreeAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SimpleCursorTreeAdapter.ViewBinder_))]
		public interface ViewBinder  : global::MonoJavaBridge.IJavaObject 
		{
			bool setViewValue(android.view.View arg0, android.database.Cursor arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SimpleCursorTreeAdapter.ViewBinder))]
		public sealed partial class ViewBinder_ : java.lang.Object, ViewBinder
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ViewBinder_()
			{
				InitJNI();
			}
			internal ViewBinder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _setViewValue11934;
			 bool android.widget.SimpleCursorTreeAdapter.ViewBinder.setViewValue(android.view.View arg0, android.database.Cursor arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.SimpleCursorTreeAdapter.ViewBinder_._setViewValue11934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.SimpleCursorTreeAdapter.ViewBinder_.staticClass, global::android.widget.SimpleCursorTreeAdapter.ViewBinder_._setViewValue11934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SimpleCursorTreeAdapter.ViewBinder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorTreeAdapter$ViewBinder"));
				global::android.widget.SimpleCursorTreeAdapter.ViewBinder_._setViewValue11934 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorTreeAdapter.ViewBinder_.staticClass, "setViewValue", "(Landroid/view/View;Landroid/database/Cursor;I)Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _bindGroupView11935;
		protected override void bindGroupView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorTreeAdapter._bindGroupView11935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._bindGroupView11935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _bindChildView11936;
		protected override void bindChildView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorTreeAdapter._bindChildView11936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._bindChildView11936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getViewBinder11937;
		public virtual global::android.widget.SimpleCursorTreeAdapter.ViewBinder getViewBinder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.SimpleCursorTreeAdapter.ViewBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorTreeAdapter._getViewBinder11937)) as android.widget.SimpleCursorTreeAdapter.ViewBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.SimpleCursorTreeAdapter.ViewBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._getViewBinder11937)) as android.widget.SimpleCursorTreeAdapter.ViewBinder;
		}
		internal static global::MonoJavaBridge.MethodId _setViewBinder11938;
		public virtual void setViewBinder(android.widget.SimpleCursorTreeAdapter.ViewBinder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorTreeAdapter._setViewBinder11938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._setViewBinder11938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setViewImage11939;
		protected virtual void setViewImage(android.widget.ImageView arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorTreeAdapter._setViewImage11939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._setViewImage11939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setViewText11940;
		public virtual void setViewText(android.widget.TextView arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorTreeAdapter._setViewText11940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._setViewText11940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _SimpleCursorTreeAdapter11941;
		public SimpleCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, int arg3, java.lang.String[] arg4, int[] arg5, int arg6, java.lang.String[] arg7, int[] arg8)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._SimpleCursorTreeAdapter11941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleCursorTreeAdapter11942;
		public SimpleCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, java.lang.String[] arg3, int[] arg4, int arg5, java.lang.String[] arg6, int[] arg7)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._SimpleCursorTreeAdapter11942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleCursorTreeAdapter11943;
		public SimpleCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, int arg3, java.lang.String[] arg4, int[] arg5, int arg6, int arg7, java.lang.String[] arg8, int[] arg9)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleCursorTreeAdapter.staticClass, global::android.widget.SimpleCursorTreeAdapter._SimpleCursorTreeAdapter11943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SimpleCursorTreeAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorTreeAdapter"));
			global::android.widget.SimpleCursorTreeAdapter._bindGroupView11935 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorTreeAdapter.staticClass, "bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
			global::android.widget.SimpleCursorTreeAdapter._bindChildView11936 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorTreeAdapter.staticClass, "bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
			global::android.widget.SimpleCursorTreeAdapter._getViewBinder11937 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorTreeAdapter.staticClass, "getViewBinder", "()Landroid/widget/SimpleCursorTreeAdapter$ViewBinder;");
			global::android.widget.SimpleCursorTreeAdapter._setViewBinder11938 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorTreeAdapter.staticClass, "setViewBinder", "(Landroid/widget/SimpleCursorTreeAdapter$ViewBinder;)V");
			global::android.widget.SimpleCursorTreeAdapter._setViewImage11939 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorTreeAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V");
			global::android.widget.SimpleCursorTreeAdapter._setViewText11940 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorTreeAdapter.staticClass, "setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V");
			global::android.widget.SimpleCursorTreeAdapter._SimpleCursorTreeAdapter11941 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;II[Ljava/lang/String;[II[Ljava/lang/String;[I)V");
			global::android.widget.SimpleCursorTreeAdapter._SimpleCursorTreeAdapter11942 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;I[Ljava/lang/String;[II[Ljava/lang/String;[I)V");
			global::android.widget.SimpleCursorTreeAdapter._SimpleCursorTreeAdapter11943 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;II[Ljava/lang/String;[III[Ljava/lang/String;[I)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SimpleCursorTreeAdapter))]
	public sealed partial class SimpleCursorTreeAdapter_ : android.widget.SimpleCursorTreeAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SimpleCursorTreeAdapter_()
		{
			InitJNI();
		}
		internal SimpleCursorTreeAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getChildrenCursor11944;
		protected override global::android.database.Cursor getChildrenCursor(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorTreeAdapter_._getChildrenCursor11944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorTreeAdapter_.staticClass, global::android.widget.SimpleCursorTreeAdapter_._getChildrenCursor11944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SimpleCursorTreeAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorTreeAdapter"));
			global::android.widget.SimpleCursorTreeAdapter_._getChildrenCursor11944 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorTreeAdapter_.staticClass, "getChildrenCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;");
		}
	}
}
