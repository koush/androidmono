namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MergeCursor : android.database.AbstractCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MergeCursor()
		{
			InitJNI();
		}
		protected MergeCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getShort2761;
		public override short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.database.MergeCursor._getShort2761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getShort2761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt2762;
		public override int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.MergeCursor._getInt2762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getInt2762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong2763;
		public override long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.MergeCursor._getLong2763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getLong2763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat2764;
		public override float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.database.MergeCursor._getFloat2764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getFloat2764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble2765;
		public override double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.database.MergeCursor._getDouble2765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getDouble2765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close2766;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MergeCursor._close2766);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._close2766);
		}
		internal static global::MonoJavaBridge.MethodId _getString2767;
		public override global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.MergeCursor._getString2767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getString2767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver2768;
		public override void registerContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MergeCursor._registerContentObserver2768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._registerContentObserver2768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver2769;
		public override void unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MergeCursor._unregisterContentObserver2769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._unregisterContentObserver2769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCount2770;
		public override int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.MergeCursor._getCount2770);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getCount2770);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames2771;
		public override global::java.lang.String[] getColumnNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.MergeCursor._getColumnNames2771)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getColumnNames2771)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getBlob2772;
		public override byte[] getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.MergeCursor._getBlob2772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getBlob2772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _isNull2773;
		public override bool isNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.MergeCursor._isNull2773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._isNull2773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deactivate2774;
		public override void deactivate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MergeCursor._deactivate2774);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._deactivate2774);
		}
		internal static global::MonoJavaBridge.MethodId _requery2775;
		public override bool requery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.MergeCursor._requery2775);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._requery2775);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver2776;
		public override void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MergeCursor._registerDataSetObserver2776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._registerDataSetObserver2776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver2777;
		public override void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MergeCursor._unregisterDataSetObserver2777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._unregisterDataSetObserver2777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMove2778;
		public override bool onMove(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.MergeCursor._onMove2778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._onMove2778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _MergeCursor2779;
		public MergeCursor(android.database.Cursor[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.MergeCursor.staticClass, global::android.database.MergeCursor._MergeCursor2779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.MergeCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/MergeCursor"));
			global::android.database.MergeCursor._getShort2761 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getShort", "(I)S");
			global::android.database.MergeCursor._getInt2762 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getInt", "(I)I");
			global::android.database.MergeCursor._getLong2763 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getLong", "(I)J");
			global::android.database.MergeCursor._getFloat2764 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getFloat", "(I)F");
			global::android.database.MergeCursor._getDouble2765 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getDouble", "(I)D");
			global::android.database.MergeCursor._close2766 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "close", "()V");
			global::android.database.MergeCursor._getString2767 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.MergeCursor._registerContentObserver2768 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.MergeCursor._unregisterContentObserver2769 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.MergeCursor._getCount2770 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getCount", "()I");
			global::android.database.MergeCursor._getColumnNames2771 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.MergeCursor._getBlob2772 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getBlob", "(I)[B");
			global::android.database.MergeCursor._isNull2773 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "isNull", "(I)Z");
			global::android.database.MergeCursor._deactivate2774 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "deactivate", "()V");
			global::android.database.MergeCursor._requery2775 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "requery", "()Z");
			global::android.database.MergeCursor._registerDataSetObserver2776 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.MergeCursor._unregisterDataSetObserver2777 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.MergeCursor._onMove2778 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "onMove", "(II)Z");
			global::android.database.MergeCursor._MergeCursor2779 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "<init>", "([Landroid/database/Cursor;)V");
		}
	}
}
