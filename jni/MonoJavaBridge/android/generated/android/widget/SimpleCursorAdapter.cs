namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SimpleCursorAdapter : android.widget.ResourceCursorAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SimpleCursorAdapter()
		{
			InitJNI();
		}
		protected SimpleCursorAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SimpleCursorAdapter.CursorToStringConverter_))]
		public interface CursorToStringConverter  : global::MonoJavaBridge.IJavaObject 
		{
			global::java.lang.CharSequence convertToString(android.database.Cursor arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SimpleCursorAdapter.CursorToStringConverter))]
		public sealed partial class CursorToStringConverter_ : java.lang.Object, CursorToStringConverter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static CursorToStringConverter_()
			{
				InitJNI();
			}
			internal CursorToStringConverter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _convertToString12465;
			 global::java.lang.CharSequence android.widget.SimpleCursorAdapter.CursorToStringConverter.convertToString(android.database.Cursor arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.CursorToStringConverter_._convertToString12465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.CursorToStringConverter_.staticClass, global::android.widget.SimpleCursorAdapter.CursorToStringConverter_._convertToString12465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SimpleCursorAdapter.CursorToStringConverter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorAdapter$CursorToStringConverter"));
				global::android.widget.SimpleCursorAdapter.CursorToStringConverter_._convertToString12465 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.CursorToStringConverter_.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SimpleCursorAdapter.ViewBinder_))]
		public interface ViewBinder  : global::MonoJavaBridge.IJavaObject 
		{
			bool setViewValue(android.view.View arg0, android.database.Cursor arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SimpleCursorAdapter.ViewBinder))]
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
			internal static global::MonoJavaBridge.MethodId _setViewValue12466;
			 bool android.widget.SimpleCursorAdapter.ViewBinder.setViewValue(android.view.View arg0, android.database.Cursor arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.ViewBinder_._setViewValue12466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.ViewBinder_.staticClass, global::android.widget.SimpleCursorAdapter.ViewBinder_._setViewValue12466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SimpleCursorAdapter.ViewBinder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorAdapter$ViewBinder"));
				global::android.widget.SimpleCursorAdapter.ViewBinder_._setViewValue12466 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.ViewBinder_.staticClass, "setViewValue", "(Landroid/view/View;Landroid/database/Cursor;I)Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _bindView12467;
		public override void bindView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._bindView12467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._bindView12467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _changeCursor12468;
		public override void changeCursor(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._changeCursor12468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._changeCursor12468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _convertToString12469;
		public override global::java.lang.CharSequence convertToString(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._convertToString12469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._convertToString12469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getViewBinder12470;
		public virtual global::android.widget.SimpleCursorAdapter.ViewBinder getViewBinder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.SimpleCursorAdapter.ViewBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._getViewBinder12470)) as android.widget.SimpleCursorAdapter.ViewBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.SimpleCursorAdapter.ViewBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._getViewBinder12470)) as android.widget.SimpleCursorAdapter.ViewBinder;
		}
		internal static global::MonoJavaBridge.MethodId _setViewBinder12471;
		public virtual void setViewBinder(android.widget.SimpleCursorAdapter.ViewBinder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._setViewBinder12471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._setViewBinder12471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setViewImage12472;
		public virtual void setViewImage(android.widget.ImageView arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._setViewImage12472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._setViewImage12472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setViewText12473;
		public virtual void setViewText(android.widget.TextView arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._setViewText12473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._setViewText12473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int StringConversionColumn
		{
			get
			{
				return getStringConversionColumn();
			}
			set
			{
				setStringConversionColumn(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStringConversionColumn12474;
		public virtual int getStringConversionColumn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._getStringConversionColumn12474);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._getStringConversionColumn12474);
		}
		internal static global::MonoJavaBridge.MethodId _setStringConversionColumn12475;
		public virtual void setStringConversionColumn(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._setStringConversionColumn12475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._setStringConversionColumn12475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCursorToStringConverter12476;
		public virtual global::android.widget.SimpleCursorAdapter.CursorToStringConverter getCursorToStringConverter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.SimpleCursorAdapter.CursorToStringConverter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._getCursorToStringConverter12476)) as android.widget.SimpleCursorAdapter.CursorToStringConverter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.SimpleCursorAdapter.CursorToStringConverter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._getCursorToStringConverter12476)) as android.widget.SimpleCursorAdapter.CursorToStringConverter;
		}
		internal static global::MonoJavaBridge.MethodId _setCursorToStringConverter12477;
		public virtual void setCursorToStringConverter(android.widget.SimpleCursorAdapter.CursorToStringConverter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._setCursorToStringConverter12477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._setCursorToStringConverter12477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _changeCursorAndColumns12478;
		public virtual void changeCursorAndColumns(android.database.Cursor arg0, java.lang.String[] arg1, int[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter._changeCursorAndColumns12478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._changeCursorAndColumns12478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _SimpleCursorAdapter12479;
		public SimpleCursorAdapter(android.content.Context arg0, int arg1, android.database.Cursor arg2, java.lang.String[] arg3, int[] arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._SimpleCursorAdapter12479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SimpleCursorAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleCursorAdapter"));
			global::android.widget.SimpleCursorAdapter._bindView12467 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V");
			global::android.widget.SimpleCursorAdapter._changeCursor12468 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "changeCursor", "(Landroid/database/Cursor;)V");
			global::android.widget.SimpleCursorAdapter._convertToString12469 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;");
			global::android.widget.SimpleCursorAdapter._getViewBinder12470 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "getViewBinder", "()Landroid/widget/SimpleCursorAdapter$ViewBinder;");
			global::android.widget.SimpleCursorAdapter._setViewBinder12471 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "setViewBinder", "(Landroid/widget/SimpleCursorAdapter$ViewBinder;)V");
			global::android.widget.SimpleCursorAdapter._setViewImage12472 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V");
			global::android.widget.SimpleCursorAdapter._setViewText12473 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V");
			global::android.widget.SimpleCursorAdapter._getStringConversionColumn12474 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "getStringConversionColumn", "()I");
			global::android.widget.SimpleCursorAdapter._setStringConversionColumn12475 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "setStringConversionColumn", "(I)V");
			global::android.widget.SimpleCursorAdapter._getCursorToStringConverter12476 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "getCursorToStringConverter", "()Landroid/widget/SimpleCursorAdapter$CursorToStringConverter;");
			global::android.widget.SimpleCursorAdapter._setCursorToStringConverter12477 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "setCursorToStringConverter", "(Landroid/widget/SimpleCursorAdapter$CursorToStringConverter;)V");
			global::android.widget.SimpleCursorAdapter._changeCursorAndColumns12478 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "changeCursorAndColumns", "(Landroid/database/Cursor;[Ljava/lang/String;[I)V");
			global::android.widget.SimpleCursorAdapter._SimpleCursorAdapter12479 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleCursorAdapter.staticClass, "<init>", "(Landroid/content/Context;ILandroid/database/Cursor;[Ljava/lang/String;[I)V");
		}
	}
}
