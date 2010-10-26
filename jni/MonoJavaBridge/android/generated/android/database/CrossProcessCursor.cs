namespace android.database
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.database.CrossProcessCursor_))]
	public partial interface CrossProcessCursor : Cursor
	{
		global::android.database.CursorWindow getWindow();
		bool onMove(int arg0, int arg1);
		void fillWindow(int arg0, android.database.CursorWindow arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.CrossProcessCursor))]
	internal sealed partial class CrossProcessCursor_ : java.lang.Object, CrossProcessCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CrossProcessCursor_()
		{
			InitJNI();
		}
		internal CrossProcessCursor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getWindow4435;
		 global::android.database.CursorWindow android.database.CrossProcessCursor.getWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getWindow4435)) as android.database.CursorWindow;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getWindow4435)) as android.database.CursorWindow;
		}
		internal static global::MonoJavaBridge.MethodId _onMove4436;
		 bool android.database.CrossProcessCursor.onMove(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._onMove4436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._onMove4436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fillWindow4437;
		 void android.database.CrossProcessCursor.fillWindow(int arg0, android.database.CursorWindow arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._fillWindow4437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._fillWindow4437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getShort4438;
		 short android.database.Cursor.getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getShort4438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getShort4438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4439;
		 int android.database.Cursor.getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getInt4439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getInt4439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong4440;
		 long android.database.Cursor.getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getLong4440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getLong4440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4441;
		 float android.database.Cursor.getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getFloat4441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getFloat4441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble4442;
		 double android.database.Cursor.getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getDouble4442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getDouble4442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close4443;
		 void android.database.Cursor.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._close4443);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._close4443);
		}
		internal static global::MonoJavaBridge.MethodId _getString4444;
		 global::java.lang.String android.database.Cursor.getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getString4444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getString4444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFirst4445;
		 bool android.database.Cursor.isFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._isFirst4445);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._isFirst4445);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed4446;
		 bool android.database.Cursor.isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._isClosed4446);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._isClosed4446);
		}
		internal static global::MonoJavaBridge.MethodId _getPosition4447;
		 int android.database.Cursor.getPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getPosition4447);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getPosition4447);
		}
		internal static global::MonoJavaBridge.MethodId _getExtras4448;
		 global::android.os.Bundle android.database.Cursor.getExtras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getExtras4448)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getExtras4448)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver4449;
		 void android.database.Cursor.registerContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._registerContentObserver4449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._registerContentObserver4449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver4450;
		 void android.database.Cursor.unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._unregisterContentObserver4450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._unregisterContentObserver4450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCount4451;
		 int android.database.Cursor.getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getCount4451);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getCount4451);
		}
		internal static global::MonoJavaBridge.MethodId _move4452;
		 bool android.database.Cursor.move(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._move4452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._move4452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToPosition4453;
		 bool android.database.Cursor.moveToPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._moveToPosition4453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._moveToPosition4453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToFirst4454;
		 bool android.database.Cursor.moveToFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._moveToFirst4454);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._moveToFirst4454);
		}
		internal static global::MonoJavaBridge.MethodId _moveToLast4455;
		 bool android.database.Cursor.moveToLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._moveToLast4455);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._moveToLast4455);
		}
		internal static global::MonoJavaBridge.MethodId _moveToNext4456;
		 bool android.database.Cursor.moveToNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._moveToNext4456);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._moveToNext4456);
		}
		internal static global::MonoJavaBridge.MethodId _moveToPrevious4457;
		 bool android.database.Cursor.moveToPrevious() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._moveToPrevious4457);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._moveToPrevious4457);
		}
		internal static global::MonoJavaBridge.MethodId _isLast4458;
		 bool android.database.Cursor.isLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._isLast4458);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._isLast4458);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst4459;
		 bool android.database.Cursor.isBeforeFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._isBeforeFirst4459);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._isBeforeFirst4459);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast4460;
		 bool android.database.Cursor.isAfterLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._isAfterLast4460);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._isAfterLast4460);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndex4461;
		 int android.database.Cursor.getColumnIndex(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getColumnIndex4461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getColumnIndex4461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndexOrThrow4462;
		 int android.database.Cursor.getColumnIndexOrThrow(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getColumnIndexOrThrow4462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getColumnIndexOrThrow4462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName4463;
		 global::java.lang.String android.database.Cursor.getColumnName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getColumnName4463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getColumnName4463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4464;
		 global::java.lang.String[] android.database.Cursor.getColumnNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getColumnNames4464)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getColumnNames4464)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount4465;
		 int android.database.Cursor.getColumnCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getColumnCount4465);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getColumnCount4465);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob4466;
		 byte[] android.database.Cursor.getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getBlob4466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getBlob4466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer4467;
		 void android.database.Cursor.copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._copyStringToBuffer4467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._copyStringToBuffer4467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull4468;
		 bool android.database.Cursor.isNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._isNull4468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._isNull4468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deactivate4469;
		 void android.database.Cursor.deactivate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._deactivate4469);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._deactivate4469);
		}
		internal static global::MonoJavaBridge.MethodId _requery4470;
		 bool android.database.Cursor.requery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._requery4470);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._requery4470);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver4471;
		 void android.database.Cursor.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._registerDataSetObserver4471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._registerDataSetObserver4471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver4472;
		 void android.database.Cursor.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._unregisterDataSetObserver4472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._unregisterDataSetObserver4472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationUri4473;
		 void android.database.Cursor.setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._setNotificationUri4473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._setNotificationUri4473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getWantsAllOnMoveCalls4474;
		 bool android.database.Cursor.getWantsAllOnMoveCalls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getWantsAllOnMoveCalls4474);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getWantsAllOnMoveCalls4474);
		}
		internal static global::MonoJavaBridge.MethodId _respond4475;
		 global::android.os.Bundle android.database.Cursor.respond(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._respond4475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._respond4475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.CrossProcessCursor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CrossProcessCursor"));
			global::android.database.CrossProcessCursor_._getWindow4435 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getWindow", "()Landroid/database/CursorWindow;");
			global::android.database.CrossProcessCursor_._onMove4436 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "onMove", "(II)Z");
			global::android.database.CrossProcessCursor_._fillWindow4437 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "fillWindow", "(ILandroid/database/CursorWindow;)V");
			global::android.database.CrossProcessCursor_._getShort4438 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getShort", "(I)S");
			global::android.database.CrossProcessCursor_._getInt4439 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getInt", "(I)I");
			global::android.database.CrossProcessCursor_._getLong4440 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getLong", "(I)J");
			global::android.database.CrossProcessCursor_._getFloat4441 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getFloat", "(I)F");
			global::android.database.CrossProcessCursor_._getDouble4442 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getDouble", "(I)D");
			global::android.database.CrossProcessCursor_._close4443 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "close", "()V");
			global::android.database.CrossProcessCursor_._getString4444 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.CrossProcessCursor_._isFirst4445 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "isFirst", "()Z");
			global::android.database.CrossProcessCursor_._isClosed4446 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "isClosed", "()Z");
			global::android.database.CrossProcessCursor_._getPosition4447 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getPosition", "()I");
			global::android.database.CrossProcessCursor_._getExtras4448 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.database.CrossProcessCursor_._registerContentObserver4449 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.CrossProcessCursor_._unregisterContentObserver4450 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.CrossProcessCursor_._getCount4451 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getCount", "()I");
			global::android.database.CrossProcessCursor_._move4452 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "move", "(I)Z");
			global::android.database.CrossProcessCursor_._moveToPosition4453 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "moveToPosition", "(I)Z");
			global::android.database.CrossProcessCursor_._moveToFirst4454 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "moveToFirst", "()Z");
			global::android.database.CrossProcessCursor_._moveToLast4455 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "moveToLast", "()Z");
			global::android.database.CrossProcessCursor_._moveToNext4456 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "moveToNext", "()Z");
			global::android.database.CrossProcessCursor_._moveToPrevious4457 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "moveToPrevious", "()Z");
			global::android.database.CrossProcessCursor_._isLast4458 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "isLast", "()Z");
			global::android.database.CrossProcessCursor_._isBeforeFirst4459 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "isBeforeFirst", "()Z");
			global::android.database.CrossProcessCursor_._isAfterLast4460 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "isAfterLast", "()Z");
			global::android.database.CrossProcessCursor_._getColumnIndex4461 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
			global::android.database.CrossProcessCursor_._getColumnIndexOrThrow4462 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			global::android.database.CrossProcessCursor_._getColumnName4463 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::android.database.CrossProcessCursor_._getColumnNames4464 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.CrossProcessCursor_._getColumnCount4465 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getColumnCount", "()I");
			global::android.database.CrossProcessCursor_._getBlob4466 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getBlob", "(I)[B");
			global::android.database.CrossProcessCursor_._copyStringToBuffer4467 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.database.CrossProcessCursor_._isNull4468 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "isNull", "(I)Z");
			global::android.database.CrossProcessCursor_._deactivate4469 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "deactivate", "()V");
			global::android.database.CrossProcessCursor_._requery4470 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "requery", "()Z");
			global::android.database.CrossProcessCursor_._registerDataSetObserver4471 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.CrossProcessCursor_._unregisterDataSetObserver4472 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.CrossProcessCursor_._setNotificationUri4473 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			global::android.database.CrossProcessCursor_._getWantsAllOnMoveCalls4474 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getWantsAllOnMoveCalls", "()Z");
			global::android.database.CrossProcessCursor_._respond4475 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
		}
	}
}
