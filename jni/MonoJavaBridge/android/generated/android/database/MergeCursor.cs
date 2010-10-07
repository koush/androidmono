namespace android.database
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class MergeCursor : android.database.AbstractCursor
	{
		internal new static global::java.lang.Class staticClass;
		static MergeCursor()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.MergeCursor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.database.MergeCursor(@__env);
			}
		}
		protected MergeCursor(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShort2594;
		public override short getShort(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this, global::android.database.MergeCursor._getShort2594, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getShort2594, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInt2595;
		public override int getInt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.MergeCursor._getInt2595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getInt2595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLong2596;
		public override long getLong(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.database.MergeCursor._getLong2596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getLong2596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2597;
		public override float getFloat(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.database.MergeCursor._getFloat2597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getFloat2597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDouble2598;
		public override double getDouble(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::android.database.MergeCursor._getDouble2598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getDouble2598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _close2599;
		public override void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.MergeCursor._close2599);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._close2599);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getString2600;
		public override global::java.lang.String getString(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.MergeCursor._getString2600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getString2600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerContentObserver2601;
		public override void registerContentObserver(android.database.ContentObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.MergeCursor._registerContentObserver2601, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._registerContentObserver2601, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterContentObserver2602;
		public override void unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.MergeCursor._unregisterContentObserver2602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._unregisterContentObserver2602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCount2603;
		public override int getCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.MergeCursor._getCount2603);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getCount2603);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNames2604;
		public override global::java.lang.String[] getColumnNames() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.MergeCursor._getColumnNames2604));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getColumnNames2604));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBlob2605;
		public override byte[] getBlob(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.MergeCursor._getBlob2605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getBlob2605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isNull2606;
		public override bool isNull(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.MergeCursor._isNull2606, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._isNull2606, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _deactivate2607;
		public override void deactivate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.MergeCursor._deactivate2607);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._deactivate2607);
		}
		internal static global::net.sf.jni4net.jni.MethodId _requery2608;
		public override bool requery() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.MergeCursor._requery2608);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._requery2608);
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver2609;
		public override void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.MergeCursor._registerDataSetObserver2609, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._registerDataSetObserver2609, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver2610;
		public override void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.MergeCursor._unregisterDataSetObserver2610, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._unregisterDataSetObserver2610, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMove2611;
		public override bool onMove(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.MergeCursor._onMove2611, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._onMove2611, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _MergeCursor2612;
		public MergeCursor(android.database.Cursor[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.MergeCursor.staticClass, global::android.database.MergeCursor._MergeCursor2612, this, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.database.Cursor[], android.database.Cursor>(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.MergeCursor.staticClass = @__class;
			global::android.database.MergeCursor._getShort2594 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "getShort", "(I)S");
			global::android.database.MergeCursor._getInt2595 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "getInt", "(I)I");
			global::android.database.MergeCursor._getLong2596 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "getLong", "(I)J");
			global::android.database.MergeCursor._getFloat2597 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "getFloat", "(I)F");
			global::android.database.MergeCursor._getDouble2598 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "getDouble", "(I)D");
			global::android.database.MergeCursor._close2599 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "close", "()V");
			global::android.database.MergeCursor._getString2600 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.MergeCursor._registerContentObserver2601 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.MergeCursor._unregisterContentObserver2602 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.MergeCursor._getCount2603 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "getCount", "()I");
			global::android.database.MergeCursor._getColumnNames2604 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.MergeCursor._getBlob2605 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "getBlob", "(I)[B");
			global::android.database.MergeCursor._isNull2606 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "isNull", "(I)Z");
			global::android.database.MergeCursor._deactivate2607 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "deactivate", "()V");
			global::android.database.MergeCursor._requery2608 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "requery", "()Z");
			global::android.database.MergeCursor._registerDataSetObserver2609 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.MergeCursor._unregisterDataSetObserver2610 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.MergeCursor._onMove2611 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "onMove", "(II)Z");
			global::android.database.MergeCursor._MergeCursor2612 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "<init>", "([Landroid/database/Cursor;)V");
		}
	}
}
