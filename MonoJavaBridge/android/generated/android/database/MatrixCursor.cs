namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MatrixCursor : android.database.AbstractCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MatrixCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class RowBuilder : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected RowBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _add4662;
			public virtual global::android.database.MatrixCursor.RowBuilder add(java.lang.Object arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.database.MatrixCursor.RowBuilder._add4662.native == global::System.IntPtr.Zero)
					global::android.database.MatrixCursor.RowBuilder._add4662 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.RowBuilder.staticClass, "add", "(Ljava/lang/Object;)Landroid/database/MatrixCursor$RowBuilder;");
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.MatrixCursor.RowBuilder.staticClass, global::android.database.MatrixCursor.RowBuilder._add4662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.database.MatrixCursor.RowBuilder;
			}
			static RowBuilder()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.database.MatrixCursor.RowBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/MatrixCursor$RowBuilder"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _getShort4663;
		public override short getShort(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.MatrixCursor._getShort4663.native == global::System.IntPtr.Zero)
				global::android.database.MatrixCursor._getShort4663 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getShort", "(I)S");
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getShort4663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4664;
		public override int getInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.MatrixCursor._getInt4664.native == global::System.IntPtr.Zero)
				global::android.database.MatrixCursor._getInt4664 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getInt", "(I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getInt4664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong4665;
		public override long getLong(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.MatrixCursor._getLong4665.native == global::System.IntPtr.Zero)
				global::android.database.MatrixCursor._getLong4665 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getLong", "(I)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getLong4665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4666;
		public override float getFloat(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.MatrixCursor._getFloat4666.native == global::System.IntPtr.Zero)
				global::android.database.MatrixCursor._getFloat4666 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getFloat", "(I)F");
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getFloat4666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble4667;
		public override double getDouble(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.MatrixCursor._getDouble4667.native == global::System.IntPtr.Zero)
				global::android.database.MatrixCursor._getDouble4667 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getDouble", "(I)D");
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getDouble4667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getString4668;
		public override global::java.lang.String getString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.MatrixCursor._getString4668.native == global::System.IntPtr.Zero)
				global::android.database.MatrixCursor._getString4668 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getString", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getString4668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
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
			if (global::android.database.MatrixCursor._getCount4669.native == global::System.IntPtr.Zero)
				global::android.database.MatrixCursor._getCount4669 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getCount", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getCount4669);
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
			if (global::android.database.MatrixCursor._getColumnNames4670.native == global::System.IntPtr.Zero)
				global::android.database.MatrixCursor._getColumnNames4670 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._getColumnNames4670) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _isNull4671;
		public override bool isNull(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.MatrixCursor._isNull4671.native == global::System.IntPtr.Zero)
				global::android.database.MatrixCursor._isNull4671 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "isNull", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._isNull4671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newRow4672;
		public virtual global::android.database.MatrixCursor.RowBuilder newRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.MatrixCursor._newRow4672.native == global::System.IntPtr.Zero)
				global::android.database.MatrixCursor._newRow4672 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "newRow", "()Landroid/database/MatrixCursor$RowBuilder;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._newRow4672) as android.database.MatrixCursor.RowBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _addRow4673;
		public virtual void addRow(java.lang.Iterable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.MatrixCursor._addRow4673.native == global::System.IntPtr.Zero)
				global::android.database.MatrixCursor._addRow4673 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "addRow", "(Ljava/lang/Iterable;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._addRow4673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addRow4674;
		public virtual void addRow(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.MatrixCursor._addRow4674.native == global::System.IntPtr.Zero)
				global::android.database.MatrixCursor._addRow4674 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "addRow", "([Ljava/lang/Object;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._addRow4674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _MatrixCursor4675;
		public MatrixCursor(java.lang.String[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.MatrixCursor._MatrixCursor4675.native == global::System.IntPtr.Zero)
				global::android.database.MatrixCursor._MatrixCursor4675 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "<init>", "([Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._MatrixCursor4675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MatrixCursor4676;
		public MatrixCursor(java.lang.String[] arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.MatrixCursor._MatrixCursor4676.native == global::System.IntPtr.Zero)
				global::android.database.MatrixCursor._MatrixCursor4676 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "<init>", "([Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._MatrixCursor4676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static MatrixCursor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.MatrixCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/MatrixCursor"));
		}
		internal static void InitJNI()
		{
		}
	}
}
