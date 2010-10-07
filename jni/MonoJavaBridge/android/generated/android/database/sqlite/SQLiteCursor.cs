namespace android.database.sqlite
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SQLiteCursor : android.database.AbstractWindowedCursor
	{
		internal new static global::java.lang.Class staticClass;
		static SQLiteCursor()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.sqlite.SQLiteCursor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.database.sqlite.SQLiteCursor(@__env);
			}
		}
		protected SQLiteCursor(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _close2631;
		public override void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursor._close2631);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._close2631);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCount2632;
		public override int getCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.sqlite.SQLiteCursor._getCount2632);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._getCount2632);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndex2633;
		public override int getColumnIndex(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.sqlite.SQLiteCursor._getColumnIndex2633, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._getColumnIndex2633, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNames2634;
		public override global::java.lang.String[] getColumnNames() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.sqlite.SQLiteCursor._getColumnNames2634));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._getColumnNames2634));
		}
		internal static global::net.sf.jni4net.jni.MethodId _deactivate2635;
		public override void deactivate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursor._deactivate2635);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._deactivate2635);
		}
		internal static global::net.sf.jni4net.jni.MethodId _requery2636;
		public override bool requery() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.sqlite.SQLiteCursor._requery2636);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._requery2636);
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver2637;
		public override void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursor._registerDataSetObserver2637, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._registerDataSetObserver2637, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMove2638;
		public override bool onMove(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.sqlite.SQLiteCursor._onMove2638, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._onMove2638, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWindow2639;
		public override void setWindow(android.database.CursorWindow arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursor._setWindow2639, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._setWindow2639, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDatabase2640;
		public virtual global::android.database.sqlite.SQLiteDatabase getDatabase() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.sqlite.SQLiteCursor._getDatabase2640));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._getDatabase2640));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelectionArguments2641;
		public virtual void setSelectionArguments(java.lang.String[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursor._setSelectionArguments2641, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._setSelectionArguments2641, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteCursor2642;
		public SQLiteCursor(android.database.sqlite.SQLiteDatabase arg0, android.database.sqlite.SQLiteCursorDriver arg1, java.lang.String arg2, android.database.sqlite.SQLiteQuery arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._SQLiteCursor2642, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.sqlite.SQLiteCursor.staticClass = @__class;
			global::android.database.sqlite.SQLiteCursor._close2631 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "close", "()V");
			global::android.database.sqlite.SQLiteCursor._getCount2632 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "getCount", "()I");
			global::android.database.sqlite.SQLiteCursor._getColumnIndex2633 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
			global::android.database.sqlite.SQLiteCursor._getColumnNames2634 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.sqlite.SQLiteCursor._deactivate2635 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "deactivate", "()V");
			global::android.database.sqlite.SQLiteCursor._requery2636 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "requery", "()Z");
			global::android.database.sqlite.SQLiteCursor._registerDataSetObserver2637 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.sqlite.SQLiteCursor._onMove2638 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "onMove", "(II)Z");
			global::android.database.sqlite.SQLiteCursor._setWindow2639 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "setWindow", "(Landroid/database/CursorWindow;)V");
			global::android.database.sqlite.SQLiteCursor._getDatabase2640 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "getDatabase", "()Landroid/database/sqlite/SQLiteDatabase;");
			global::android.database.sqlite.SQLiteCursor._setSelectionArguments2641 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "setSelectionArguments", "([Ljava/lang/String;)V");
			global::android.database.sqlite.SQLiteCursor._SQLiteCursor2642 = @__env.GetMethodID(global::android.database.sqlite.SQLiteCursor.staticClass, "<init>", "(Landroid/database/sqlite/SQLiteDatabase;Landroid/database/sqlite/SQLiteCursorDriver;Ljava/lang/String;Landroid/database/sqlite/SQLiteQuery;)V");
		}
	}
}
