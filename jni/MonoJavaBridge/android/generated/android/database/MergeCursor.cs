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
		internal static global::MonoJavaBridge.MethodId _getShort4660;
		public override short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.database.MergeCursor._getShort4660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getShort4660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4661;
		public override int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.MergeCursor._getInt4661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getInt4661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong4662;
		public override long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.MergeCursor._getLong4662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getLong4662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4663;
		public override float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.database.MergeCursor._getFloat4663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getFloat4663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble4664;
		public override double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.database.MergeCursor._getDouble4664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getDouble4664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close4665;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MergeCursor._close4665);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._close4665);
		}
		internal static global::MonoJavaBridge.MethodId _getString4666;
		public override global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.MergeCursor._getString4666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getString4666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver4667;
		public override void registerContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MergeCursor._registerContentObserver4667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._registerContentObserver4667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver4668;
		public override void unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MergeCursor._unregisterContentObserver4668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._unregisterContentObserver4668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount4669;
		public override int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.MergeCursor._getCount4669);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getCount4669);
		}
		public new global::java.lang.String[] ColumnNames
		{
			get
			{
				return getColumnNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4670;
		public override global::java.lang.String[] getColumnNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.MergeCursor._getColumnNames4670)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getColumnNames4670)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getBlob4671;
		public override byte[] getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.MergeCursor._getBlob4671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getBlob4671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _isNull4672;
		public override bool isNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.MergeCursor._isNull4672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._isNull4672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deactivate4673;
		public override void deactivate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MergeCursor._deactivate4673);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._deactivate4673);
		}
		internal static global::MonoJavaBridge.MethodId _requery4674;
		public override bool requery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.MergeCursor._requery4674);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._requery4674);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver4675;
		public override void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MergeCursor._registerDataSetObserver4675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._registerDataSetObserver4675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver4676;
		public override void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MergeCursor._unregisterDataSetObserver4676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._unregisterDataSetObserver4676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMove4677;
		public override bool onMove(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.MergeCursor._onMove4677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._onMove4677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _MergeCursor4678;
		public MergeCursor(android.database.Cursor[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.MergeCursor.staticClass, global::android.database.MergeCursor._MergeCursor4678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.MergeCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/MergeCursor"));
			global::android.database.MergeCursor._getShort4660 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getShort", "(I)S");
			global::android.database.MergeCursor._getInt4661 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getInt", "(I)I");
			global::android.database.MergeCursor._getLong4662 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getLong", "(I)J");
			global::android.database.MergeCursor._getFloat4663 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getFloat", "(I)F");
			global::android.database.MergeCursor._getDouble4664 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getDouble", "(I)D");
			global::android.database.MergeCursor._close4665 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "close", "()V");
			global::android.database.MergeCursor._getString4666 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.MergeCursor._registerContentObserver4667 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.MergeCursor._unregisterContentObserver4668 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.MergeCursor._getCount4669 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getCount", "()I");
			global::android.database.MergeCursor._getColumnNames4670 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.MergeCursor._getBlob4671 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getBlob", "(I)[B");
			global::android.database.MergeCursor._isNull4672 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "isNull", "(I)Z");
			global::android.database.MergeCursor._deactivate4673 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "deactivate", "()V");
			global::android.database.MergeCursor._requery4674 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "requery", "()Z");
			global::android.database.MergeCursor._registerDataSetObserver4675 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.MergeCursor._unregisterDataSetObserver4676 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.MergeCursor._onMove4677 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "onMove", "(II)Z");
			global::android.database.MergeCursor._MergeCursor4678 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "<init>", "([Landroid/database/Cursor;)V");
		}
	}
}
