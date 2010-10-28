namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MergeCursor : android.database.AbstractCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MergeCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getShort4677;
		public override short getShort(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.database.MergeCursor._getShort4677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getShort4677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4678;
		public override int getInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.MergeCursor._getInt4678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getInt4678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong4679;
		public override long getLong(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.MergeCursor._getLong4679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getLong4679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4680;
		public override float getFloat(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.database.MergeCursor._getFloat4680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getFloat4680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble4681;
		public override double getDouble(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.database.MergeCursor._getDouble4681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getDouble4681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close4682;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MergeCursor._close4682);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._close4682);
		}
		internal static global::MonoJavaBridge.MethodId _getString4683;
		public override global::java.lang.String getString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.MergeCursor._getString4683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getString4683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver4684;
		public override void registerContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MergeCursor._registerContentObserver4684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._registerContentObserver4684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver4685;
		public override void unregisterContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MergeCursor._unregisterContentObserver4685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._unregisterContentObserver4685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount4686;
		public override int getCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.MergeCursor._getCount4686);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getCount4686);
		}
		public new global::java.lang.String[] ColumnNames
		{
			get
			{
				return getColumnNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4687;
		public override global::java.lang.String[] getColumnNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.MergeCursor._getColumnNames4687)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getColumnNames4687)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getBlob4688;
		public override byte[] getBlob(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.MergeCursor._getBlob4688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._getBlob4688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _isNull4689;
		public override bool isNull(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.MergeCursor._isNull4689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._isNull4689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deactivate4690;
		public override void deactivate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MergeCursor._deactivate4690);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._deactivate4690);
		}
		internal static global::MonoJavaBridge.MethodId _requery4691;
		public override bool requery()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.MergeCursor._requery4691);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._requery4691);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver4692;
		public override void registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MergeCursor._registerDataSetObserver4692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._registerDataSetObserver4692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver4693;
		public override void unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.MergeCursor._unregisterDataSetObserver4693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._unregisterDataSetObserver4693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMove4694;
		public override bool onMove(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.MergeCursor._onMove4694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.MergeCursor.staticClass, global::android.database.MergeCursor._onMove4694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _MergeCursor4695;
		public MergeCursor(android.database.Cursor[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.MergeCursor.staticClass, global::android.database.MergeCursor._MergeCursor4695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static MergeCursor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.MergeCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/MergeCursor"));
			global::android.database.MergeCursor._getShort4677 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getShort", "(I)S");
			global::android.database.MergeCursor._getInt4678 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getInt", "(I)I");
			global::android.database.MergeCursor._getLong4679 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getLong", "(I)J");
			global::android.database.MergeCursor._getFloat4680 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getFloat", "(I)F");
			global::android.database.MergeCursor._getDouble4681 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getDouble", "(I)D");
			global::android.database.MergeCursor._close4682 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "close", "()V");
			global::android.database.MergeCursor._getString4683 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.MergeCursor._registerContentObserver4684 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.MergeCursor._unregisterContentObserver4685 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.MergeCursor._getCount4686 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getCount", "()I");
			global::android.database.MergeCursor._getColumnNames4687 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.MergeCursor._getBlob4688 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "getBlob", "(I)[B");
			global::android.database.MergeCursor._isNull4689 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "isNull", "(I)Z");
			global::android.database.MergeCursor._deactivate4690 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "deactivate", "()V");
			global::android.database.MergeCursor._requery4691 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "requery", "()Z");
			global::android.database.MergeCursor._registerDataSetObserver4692 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.MergeCursor._unregisterDataSetObserver4693 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.MergeCursor._onMove4694 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "onMove", "(II)Z");
			global::android.database.MergeCursor._MergeCursor4695 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "<init>", "([Landroid/database/Cursor;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
