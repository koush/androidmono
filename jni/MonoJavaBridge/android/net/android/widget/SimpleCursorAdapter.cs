namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SimpleCursorAdapter : android.widget.ResourceCursorAdapter
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SimpleCursorAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.SimpleCursorAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			java.lang.CharSequence convertToString(android.database.Cursor arg0); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface ViewBinder 
		{ 
			bool setViewValue(android.view.View arg0, android.database.Cursor arg1, int arg2); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newView10037; 
		public override android.view.View newView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _newView10037, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SimpleCursorAdapter.staticClass, _newView10037, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newDropDownView10038; 
		public override android.view.View newDropDownView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _newDropDownView10038, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SimpleCursorAdapter.staticClass, _newDropDownView10038, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bindView10039; 
		public override void bindView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorAdapter)) 
				@__env.CallVoidMethod(this, _bindView10039, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SimpleCursorAdapter.staticClass, _bindView10039, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _changeCursor10040; 
		public override void changeCursor(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorAdapter)) 
				@__env.CallVoidMethod(this, _changeCursor10040, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SimpleCursorAdapter.staticClass, _changeCursor10040, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _convertToString10041; 
		public override java.lang.CharSequence convertToString(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _convertToString10041, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SimpleCursorAdapter.staticClass, _convertToString10041, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getViewBinder10042; 
		public virtual android.widget.SimpleCursorAdapter.ViewBinder getViewBinder() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.SimpleCursorAdapter.ViewBinder>(@__env, @__env.CallObjectMethodPtr(this, _getViewBinder10042)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.SimpleCursorAdapter.ViewBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SimpleCursorAdapter.staticClass, _getViewBinder10042)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setViewBinder10043; 
		public virtual void setViewBinder(android.widget.SimpleCursorAdapter.ViewBinder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorAdapter)) 
				@__env.CallVoidMethod(this, _setViewBinder10043, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SimpleCursorAdapter.staticClass, _setViewBinder10043, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setViewImage10044; 
		public virtual void setViewImage(android.widget.ImageView arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorAdapter)) 
				@__env.CallVoidMethod(this, _setViewImage10044, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SimpleCursorAdapter.staticClass, _setViewImage10044, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setViewText10045; 
		public virtual void setViewText(android.widget.TextView arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorAdapter)) 
				@__env.CallVoidMethod(this, _setViewText10045, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SimpleCursorAdapter.staticClass, _setViewText10045, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStringConversionColumn10046; 
		public virtual int getStringConversionColumn() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorAdapter)) 
				return @__env.CallIntMethod(this, _getStringConversionColumn10046); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.SimpleCursorAdapter.staticClass, _getStringConversionColumn10046); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStringConversionColumn10047; 
		public virtual void setStringConversionColumn(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorAdapter)) 
				@__env.CallVoidMethod(this, _setStringConversionColumn10047, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SimpleCursorAdapter.staticClass, _setStringConversionColumn10047, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCursorToStringConverter10048; 
		public virtual android.widget.SimpleCursorAdapter.CursorToStringConverter getCursorToStringConverter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.SimpleCursorAdapter.CursorToStringConverter>(@__env, @__env.CallObjectMethodPtr(this, _getCursorToStringConverter10048)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.SimpleCursorAdapter.CursorToStringConverter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SimpleCursorAdapter.staticClass, _getCursorToStringConverter10048)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCursorToStringConverter10049; 
		public virtual void setCursorToStringConverter(android.widget.SimpleCursorAdapter.CursorToStringConverter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorAdapter)) 
				@__env.CallVoidMethod(this, _setCursorToStringConverter10049, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SimpleCursorAdapter.staticClass, _setCursorToStringConverter10049, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _changeCursorAndColumns10050; 
		public virtual void changeCursorAndColumns(android.database.Cursor arg0, java.lang.String[] arg1, int[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleCursorAdapter)) 
				@__env.CallVoidMethod(this, _changeCursorAndColumns10050, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SimpleCursorAdapter.staticClass, _changeCursorAndColumns10050, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SimpleCursorAdapter10051; 
		public SimpleCursorAdapter(android.content.Context arg0, int arg1, android.database.Cursor arg2, java.lang.String[] arg3, int[] arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.SimpleCursorAdapter.staticClass, _SimpleCursorAdapter10051, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.SimpleCursorAdapter.staticClass = @__class; 
			global::android.widget.SimpleCursorAdapter._newView10037 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "newView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.SimpleCursorAdapter._newDropDownView10038 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "newDropDownView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.SimpleCursorAdapter._bindView10039 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V"); 
			global::android.widget.SimpleCursorAdapter._changeCursor10040 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "changeCursor", "(Landroid/database/Cursor;)V"); 
			global::android.widget.SimpleCursorAdapter._convertToString10041 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;"); 
			global::android.widget.SimpleCursorAdapter._getViewBinder10042 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "getViewBinder", "()Landroid/widget/SimpleCursorAdapter$ViewBinder;"); 
			global::android.widget.SimpleCursorAdapter._setViewBinder10043 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "setViewBinder", "(Landroid/widget/SimpleCursorAdapter$ViewBinder;)V"); 
			global::android.widget.SimpleCursorAdapter._setViewImage10044 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V"); 
			global::android.widget.SimpleCursorAdapter._setViewText10045 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V"); 
			global::android.widget.SimpleCursorAdapter._getStringConversionColumn10046 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "getStringConversionColumn", "()I"); 
			global::android.widget.SimpleCursorAdapter._setStringConversionColumn10047 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "setStringConversionColumn", "(I)V"); 
			global::android.widget.SimpleCursorAdapter._getCursorToStringConverter10048 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "getCursorToStringConverter", "()Landroid/widget/SimpleCursorAdapter$CursorToStringConverter;"); 
			global::android.widget.SimpleCursorAdapter._setCursorToStringConverter10049 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "setCursorToStringConverter", "(Landroid/widget/SimpleCursorAdapter$CursorToStringConverter;)V"); 
			global::android.widget.SimpleCursorAdapter._changeCursorAndColumns10050 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "changeCursorAndColumns", "(Landroid/database/Cursor;[Ljava/lang/String;[I)V"); 
			global::android.widget.SimpleCursorAdapter._SimpleCursorAdapter10051 = @__env.GetMethodID(global::android.widget.SimpleCursorAdapter.staticClass, "<init>", "(Landroid/content/Context;ILandroid/database/Cursor;[Ljava/lang/String;[I)V"); 
		} 
	} 
} 
