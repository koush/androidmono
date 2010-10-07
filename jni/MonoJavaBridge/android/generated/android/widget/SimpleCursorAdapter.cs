namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SimpleCursorAdapter : android.widget.ResourceCursorAdapter
	{
		internal new static global::java.lang.Class staticClass;
		static SimpleCursorAdapter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.SimpleCursorAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.SimpleCursorAdapter(@__env);
			}
		}
		protected SimpleCursorAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface CursorToStringConverter 
		{
			global::java.lang.CharSequence convertToString(android.database.Cursor arg0);
		}

		public partial class CursorToStringConverter_
		{
			public static global::java.lang.Class _class
			{
				get { return __CursorToStringConverter.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __CursorToStringConverter : java.lang.Object, CursorToStringConverter
		{
			internal static global::java.lang.Class staticClass;
			static __CursorToStringConverter()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.SimpleCursorAdapter.__CursorToStringConverter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.SimpleCursorAdapter.__CursorToStringConverter(@__env);
				}
			}
			internal __CursorToStringConverter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _convertToString11533;
			 global::java.lang.CharSequence android.widget.SimpleCursorAdapter.CursorToStringConverter.convertToString(android.database.Cursor arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SimpleCursorAdapter.__CursorToStringConverter._convertToString11533, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SimpleCursorAdapter.__CursorToStringConverter.staticClass, global::android.widget.SimpleCursorAdapter.__CursorToStringConverter._convertToString11533, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.SimpleCursorAdapter.__CursorToStringConverter.staticClass = @__class;
				global::android.widget.SimpleCursorAdapter.__CursorToStringConverter._convertToString11533 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.__CursorToStringConverter.staticClass, "android.widget.SimpleCursorAdapter.CursorToStringConverter.convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;");
			}
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.SimpleCursorAdapter.__ViewBinder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.SimpleCursorAdapter.__ViewBinder(@__env);
				}
			}
			internal __ViewBinder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _setViewValue11534;
			 bool android.widget.SimpleCursorAdapter.ViewBinder.setViewValue(android.view.View arg0, android.database.Cursor arg1, int arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.widget.SimpleCursorAdapter.__ViewBinder._setViewValue11534, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.SimpleCursorAdapter.__ViewBinder.staticClass, global::android.widget.SimpleCursorAdapter.__ViewBinder._setViewValue11534, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.SimpleCursorAdapter.__ViewBinder.staticClass = @__class;
				global::android.widget.SimpleCursorAdapter.__ViewBinder._setViewValue11534 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.__ViewBinder.staticClass, "android.widget.SimpleCursorAdapter.ViewBinder.setViewValue", "(Landroid/view/View;Landroid/database/Cursor;I)Z");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _bindView11535;
		public override void bindView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SimpleCursorAdapter._bindView11535, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._bindView11535, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _changeCursor11536;
		public override void changeCursor(android.database.Cursor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SimpleCursorAdapter._changeCursor11536, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._changeCursor11536, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _convertToString11537;
		public override global::java.lang.CharSequence convertToString(android.database.Cursor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SimpleCursorAdapter._convertToString11537, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._convertToString11537, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getViewBinder11538;
		public virtual global::android.widget.SimpleCursorAdapter.ViewBinder getViewBinder() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.SimpleCursorAdapter.ViewBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SimpleCursorAdapter._getViewBinder11538));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.SimpleCursorAdapter.ViewBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._getViewBinder11538));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setViewBinder11539;
		public virtual void setViewBinder(android.widget.SimpleCursorAdapter.ViewBinder arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SimpleCursorAdapter._setViewBinder11539, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._setViewBinder11539, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setViewImage11540;
		public virtual void setViewImage(android.widget.ImageView arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SimpleCursorAdapter._setViewImage11540, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._setViewImage11540, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setViewText11541;
		public virtual void setViewText(android.widget.TextView arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SimpleCursorAdapter._setViewText11541, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._setViewText11541, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStringConversionColumn11542;
		public virtual int getStringConversionColumn() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.SimpleCursorAdapter._getStringConversionColumn11542);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._getStringConversionColumn11542);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStringConversionColumn11543;
		public virtual void setStringConversionColumn(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SimpleCursorAdapter._setStringConversionColumn11543, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._setStringConversionColumn11543, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCursorToStringConverter11544;
		public virtual global::android.widget.SimpleCursorAdapter.CursorToStringConverter getCursorToStringConverter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.SimpleCursorAdapter.CursorToStringConverter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SimpleCursorAdapter._getCursorToStringConverter11544));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.SimpleCursorAdapter.CursorToStringConverter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._getCursorToStringConverter11544));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCursorToStringConverter11545;
		public virtual void setCursorToStringConverter(android.widget.SimpleCursorAdapter.CursorToStringConverter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SimpleCursorAdapter._setCursorToStringConverter11545, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._setCursorToStringConverter11545, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _changeCursorAndColumns11546;
		public virtual void changeCursorAndColumns(android.database.Cursor arg0, java.lang.String[] arg1, int[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SimpleCursorAdapter._changeCursorAndColumns11546, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._changeCursorAndColumns11546, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SimpleCursorAdapter11547;
		public SimpleCursorAdapter(android.content.Context arg0, int arg1, android.database.Cursor arg2, java.lang.String[] arg3, int[] arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.SimpleCursorAdapter.staticClass, global::android.widget.SimpleCursorAdapter._SimpleCursorAdapter11547, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.SimpleCursorAdapter.staticClass = @__class;
			global::android.widget.SimpleCursorAdapter._bindView11535 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V");
			global::android.widget.SimpleCursorAdapter._changeCursor11536 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "changeCursor", "(Landroid/database/Cursor;)V");
			global::android.widget.SimpleCursorAdapter._convertToString11537 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;");
			global::android.widget.SimpleCursorAdapter._getViewBinder11538 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "getViewBinder", "()Landroid/widget/SimpleCursorAdapter$ViewBinder;");
			global::android.widget.SimpleCursorAdapter._setViewBinder11539 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "setViewBinder", "(Landroid/widget/SimpleCursorAdapter$ViewBinder;)V");
			global::android.widget.SimpleCursorAdapter._setViewImage11540 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V");
			global::android.widget.SimpleCursorAdapter._setViewText11541 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V");
			global::android.widget.SimpleCursorAdapter._getStringConversionColumn11542 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "getStringConversionColumn", "()I");
			global::android.widget.SimpleCursorAdapter._setStringConversionColumn11543 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "setStringConversionColumn", "(I)V");
			global::android.widget.SimpleCursorAdapter._getCursorToStringConverter11544 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "getCursorToStringConverter", "()Landroid/widget/SimpleCursorAdapter$CursorToStringConverter;");
			global::android.widget.SimpleCursorAdapter._setCursorToStringConverter11545 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "setCursorToStringConverter", "(Landroid/widget/SimpleCursorAdapter$CursorToStringConverter;)V");
			global::android.widget.SimpleCursorAdapter._changeCursorAndColumns11546 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "changeCursorAndColumns", "(Landroid/database/Cursor;[Ljava/lang/String;[I)V");
			global::android.widget.SimpleCursorAdapter._SimpleCursorAdapter11547 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "<init>", "(Landroid/content/Context;ILandroid/database/Cursor;[Ljava/lang/String;[I)V");
		}
	}
}
