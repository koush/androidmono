namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.ResultSet_))]
	public partial interface ResultSet  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object getObject(java.lang.String arg0);
		global::java.lang.Object getObject(int arg0, java.util.Map arg1);
		global::java.lang.Object getObject(int arg0);
		global::java.lang.Object getObject(java.lang.String arg0, java.util.Map arg1);
		bool getBoolean(java.lang.String arg0);
		bool getBoolean(int arg0);
		byte getByte(java.lang.String arg0);
		byte getByte(int arg0);
		short getShort(int arg0);
		short getShort(java.lang.String arg0);
		int getInt(java.lang.String arg0);
		int getInt(int arg0);
		long getLong(java.lang.String arg0);
		long getLong(int arg0);
		float getFloat(java.lang.String arg0);
		float getFloat(int arg0);
		double getDouble(int arg0);
		double getDouble(java.lang.String arg0);
		byte[] getBytes(java.lang.String arg0);
		byte[] getBytes(int arg0);
		global::java.sql.Array getArray(java.lang.String arg0);
		global::java.sql.Array getArray(int arg0);
		bool next();
		global::java.net.URL getURL(java.lang.String arg0);
		global::java.net.URL getURL(int arg0);
		void close();
		int getType();
		bool previous();
		global::java.sql.Ref getRef(int arg0);
		global::java.sql.Ref getRef(java.lang.String arg0);
		global::java.lang.String getString(java.lang.String arg0);
		global::java.lang.String getString(int arg0);
		bool isFirst();
		global::java.sql.Time getTime(java.lang.String arg0, java.util.Calendar arg1);
		global::java.sql.Time getTime(java.lang.String arg0);
		global::java.sql.Time getTime(int arg0, java.util.Calendar arg1);
		global::java.sql.Time getTime(int arg0);
		global::java.sql.Date getDate(java.lang.String arg0);
		global::java.sql.Date getDate(java.lang.String arg0, java.util.Calendar arg1);
		global::java.sql.Date getDate(int arg0);
		global::java.sql.Date getDate(int arg0, java.util.Calendar arg1);
		bool isClosed();
		global::java.sql.Timestamp getTimestamp(java.lang.String arg0);
		global::java.sql.Timestamp getTimestamp(int arg0, java.util.Calendar arg1);
		global::java.sql.Timestamp getTimestamp(java.lang.String arg0, java.util.Calendar arg1);
		global::java.sql.Timestamp getTimestamp(int arg0);
		bool last();
		bool first();
		void updateBytes(java.lang.String arg0, byte[] arg1);
		void updateBytes(int arg0, byte[] arg1);
		bool isLast();
		bool isBeforeFirst();
		bool isAfterLast();
		global::java.sql.Blob getBlob(java.lang.String arg0);
		global::java.sql.Blob getBlob(int arg0);
		void updateDate(int arg0, java.sql.Date arg1);
		void updateDate(java.lang.String arg0, java.sql.Date arg1);
		void updateTime(int arg0, java.sql.Time arg1);
		void updateTime(java.lang.String arg0, java.sql.Time arg1);
		void deleteRow();
		void updateBlob(java.lang.String arg0, java.sql.Blob arg1);
		void updateBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2);
		void updateBlob(int arg0, java.io.InputStream arg1);
		void updateBlob(int arg0, java.io.InputStream arg1, long arg2);
		void updateBlob(java.lang.String arg0, java.io.InputStream arg1);
		void updateBlob(int arg0, java.sql.Blob arg1);
		void updateDouble(int arg0, double arg1);
		void updateDouble(java.lang.String arg0, double arg1);
		void updateFloat(java.lang.String arg0, float arg1);
		void updateFloat(int arg0, float arg1);
		void updateInt(java.lang.String arg0, int arg1);
		void updateInt(int arg0, int arg1);
		void updateLong(java.lang.String arg0, long arg1);
		void updateLong(int arg0, long arg1);
		void updateShort(int arg0, short arg1);
		void updateShort(java.lang.String arg0, short arg1);
		void updateString(int arg0, java.lang.String arg1);
		void updateString(java.lang.String arg0, java.lang.String arg1);
		bool wasNull();
		global::java.math.BigDecimal getBigDecimal(int arg0, int arg1);
		global::java.math.BigDecimal getBigDecimal(int arg0);
		global::java.math.BigDecimal getBigDecimal(java.lang.String arg0);
		global::java.math.BigDecimal getBigDecimal(java.lang.String arg0, int arg1);
		global::java.io.InputStream getAsciiStream(java.lang.String arg0);
		global::java.io.InputStream getAsciiStream(int arg0);
		global::java.io.InputStream getUnicodeStream(java.lang.String arg0);
		global::java.io.InputStream getUnicodeStream(int arg0);
		global::java.io.InputStream getBinaryStream(int arg0);
		global::java.io.InputStream getBinaryStream(java.lang.String arg0);
		global::java.sql.SQLWarning getWarnings();
		void clearWarnings();
		global::java.lang.String getCursorName();
		global::java.sql.ResultSetMetaData getMetaData();
		int findColumn(java.lang.String arg0);
		global::java.io.Reader getCharacterStream(java.lang.String arg0);
		global::java.io.Reader getCharacterStream(int arg0);
		void beforeFirst();
		void afterLast();
		int getRow();
		bool absolute(int arg0);
		bool relative(int arg0);
		void setFetchDirection(int arg0);
		int getFetchDirection();
		void setFetchSize(int arg0);
		int getFetchSize();
		int getConcurrency();
		bool rowUpdated();
		bool rowInserted();
		bool rowDeleted();
		void updateNull(java.lang.String arg0);
		void updateNull(int arg0);
		void updateBoolean(int arg0, bool arg1);
		void updateBoolean(java.lang.String arg0, bool arg1);
		void updateByte(int arg0, byte arg1);
		void updateByte(java.lang.String arg0, byte arg1);
		void updateBigDecimal(int arg0, java.math.BigDecimal arg1);
		void updateBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1);
		void updateTimestamp(java.lang.String arg0, java.sql.Timestamp arg1);
		void updateTimestamp(int arg0, java.sql.Timestamp arg1);
		void updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1);
		void updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1, long arg2);
		void updateAsciiStream(int arg0, java.io.InputStream arg1, long arg2);
		void updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2);
		void updateAsciiStream(int arg0, java.io.InputStream arg1);
		void updateAsciiStream(int arg0, java.io.InputStream arg1, int arg2);
		void updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2);
		void updateBinaryStream(int arg0, java.io.InputStream arg1, int arg2);
		void updateBinaryStream(int arg0, java.io.InputStream arg1, long arg2);
		void updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1, long arg2);
		void updateBinaryStream(int arg0, java.io.InputStream arg1);
		void updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1);
		void updateCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2);
		void updateCharacterStream(int arg0, java.io.Reader arg1, int arg2);
		void updateCharacterStream(int arg0, java.io.Reader arg1, long arg2);
		void updateCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void updateCharacterStream(int arg0, java.io.Reader arg1);
		void updateCharacterStream(java.lang.String arg0, java.io.Reader arg1);
		void updateObject(java.lang.String arg0, java.lang.Object arg1);
		void updateObject(int arg0, java.lang.Object arg1);
		void updateObject(int arg0, java.lang.Object arg1, int arg2);
		void updateObject(java.lang.String arg0, java.lang.Object arg1, int arg2);
		void insertRow();
		void updateRow();
		void refreshRow();
		void cancelRowUpdates();
		void moveToInsertRow();
		void moveToCurrentRow();
		global::java.sql.Statement getStatement();
		global::java.sql.Clob getClob(java.lang.String arg0);
		global::java.sql.Clob getClob(int arg0);
		void updateRef(java.lang.String arg0, java.sql.Ref arg1);
		void updateRef(int arg0, java.sql.Ref arg1);
		void updateClob(java.lang.String arg0, java.sql.Clob arg1);
		void updateClob(int arg0, java.io.Reader arg1);
		void updateClob(java.lang.String arg0, java.io.Reader arg1);
		void updateClob(int arg0, java.io.Reader arg1, long arg2);
		void updateClob(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void updateClob(int arg0, java.sql.Clob arg1);
		void updateArray(int arg0, java.sql.Array arg1);
		void updateArray(java.lang.String arg0, java.sql.Array arg1);
		int getHoldability();
		void updateNString(java.lang.String arg0, java.lang.String arg1);
		void updateNString(int arg0, java.lang.String arg1);
		void updateNClob(int arg0, java.io.Reader arg1);
		void updateNClob(int arg0, java.io.Reader arg1, long arg2);
		void updateNClob(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void updateNClob(java.lang.String arg0, java.io.Reader arg1);
		global::java.lang.String getNString(java.lang.String arg0);
		global::java.lang.String getNString(int arg0);
		global::java.io.Reader getNCharacterStream(int arg0);
		global::java.io.Reader getNCharacterStream(java.lang.String arg0);
		void updateNCharacterStream(int arg0, java.io.Reader arg1);
		void updateNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void updateNCharacterStream(int arg0, java.io.Reader arg1, long arg2);
		void updateNCharacterStream(java.lang.String arg0, java.io.Reader arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.ResultSet))]
	internal sealed partial class ResultSet_ : java.lang.Object, ResultSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ResultSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object java.sql.ResultSet.getObject(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getObject", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::java.sql.ResultSet_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.Object java.sql.ResultSet.getObject(int arg0, java.util.Map arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getObject", "(ILjava/util/Map;)Ljava/lang/Object;", ref global::java.sql.ResultSet_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.Object java.sql.ResultSet.getObject(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getObject", "(I)Ljava/lang/Object;", ref global::java.sql.ResultSet_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.Object java.sql.ResultSet.getObject(java.lang.String arg0, java.util.Map arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getObject", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;", ref global::java.sql.ResultSet_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		bool java.sql.ResultSet.getBoolean(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSet_.staticClass, "getBoolean", "(Ljava/lang/String;)Z", ref global::java.sql.ResultSet_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		bool java.sql.ResultSet.getBoolean(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSet_.staticClass, "getBoolean", "(I)Z", ref global::java.sql.ResultSet_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		byte java.sql.ResultSet.getByte(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.sql.ResultSet_.staticClass, "getByte", "(Ljava/lang/String;)B", ref global::java.sql.ResultSet_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		byte java.sql.ResultSet.getByte(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.sql.ResultSet_.staticClass, "getByte", "(I)B", ref global::java.sql.ResultSet_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		short java.sql.ResultSet.getShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.sql.ResultSet_.staticClass, "getShort", "(I)S", ref global::java.sql.ResultSet_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		short java.sql.ResultSet.getShort(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.sql.ResultSet_.staticClass, "getShort", "(Ljava/lang/String;)S", ref global::java.sql.ResultSet_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		int java.sql.ResultSet.getInt(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ResultSet_.staticClass, "getInt", "(Ljava/lang/String;)I", ref global::java.sql.ResultSet_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		int java.sql.ResultSet.getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ResultSet_.staticClass, "getInt", "(I)I", ref global::java.sql.ResultSet_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		long java.sql.ResultSet.getLong(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.sql.ResultSet_.staticClass, "getLong", "(Ljava/lang/String;)J", ref global::java.sql.ResultSet_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		long java.sql.ResultSet.getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.sql.ResultSet_.staticClass, "getLong", "(I)J", ref global::java.sql.ResultSet_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		float java.sql.ResultSet.getFloat(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.sql.ResultSet_.staticClass, "getFloat", "(Ljava/lang/String;)F", ref global::java.sql.ResultSet_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		float java.sql.ResultSet.getFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.sql.ResultSet_.staticClass, "getFloat", "(I)F", ref global::java.sql.ResultSet_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		double java.sql.ResultSet.getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.sql.ResultSet_.staticClass, "getDouble", "(I)D", ref global::java.sql.ResultSet_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		double java.sql.ResultSet.getDouble(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.sql.ResultSet_.staticClass, "getDouble", "(Ljava/lang/String;)D", ref global::java.sql.ResultSet_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		byte[] java.sql.ResultSet.getBytes(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.sql.ResultSet_.staticClass, "getBytes", "(Ljava/lang/String;)[B", ref global::java.sql.ResultSet_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m19;
		byte[] java.sql.ResultSet.getBytes(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.sql.ResultSet_.staticClass, "getBytes", "(I)[B", ref global::java.sql.ResultSet_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m20;
		global::java.sql.Array java.sql.ResultSet.getArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Array>(this, global::java.sql.ResultSet_.staticClass, "getArray", "(Ljava/lang/String;)Ljava/sql/Array;", ref global::java.sql.ResultSet_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Array;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		global::java.sql.Array java.sql.ResultSet.getArray(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Array>(this, global::java.sql.ResultSet_.staticClass, "getArray", "(I)Ljava/sql/Array;", ref global::java.sql.ResultSet_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Array;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		bool java.sql.ResultSet.next()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSet_.staticClass, "next", "()Z", ref global::java.sql.ResultSet_._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		global::java.net.URL java.sql.ResultSet.getURL(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.sql.ResultSet_.staticClass, "getURL", "(Ljava/lang/String;)Ljava/net/URL;", ref global::java.sql.ResultSet_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URL;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		global::java.net.URL java.sql.ResultSet.getURL(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.sql.ResultSet_.staticClass, "getURL", "(I)Ljava/net/URL;", ref global::java.sql.ResultSet_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URL;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		void java.sql.ResultSet.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "close", "()V", ref global::java.sql.ResultSet_._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		int java.sql.ResultSet.getType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ResultSet_.staticClass, "getType", "()I", ref global::java.sql.ResultSet_._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		bool java.sql.ResultSet.previous()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSet_.staticClass, "previous", "()Z", ref global::java.sql.ResultSet_._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		global::java.sql.Ref java.sql.ResultSet.getRef(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Ref>(this, global::java.sql.ResultSet_.staticClass, "getRef", "(I)Ljava/sql/Ref;", ref global::java.sql.ResultSet_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Ref;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		global::java.sql.Ref java.sql.ResultSet.getRef(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Ref>(this, global::java.sql.ResultSet_.staticClass, "getRef", "(Ljava/lang/String;)Ljava/sql/Ref;", ref global::java.sql.ResultSet_._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Ref;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		global::java.lang.String java.sql.ResultSet.getString(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.ResultSet_.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.sql.ResultSet_._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		global::java.lang.String java.sql.ResultSet.getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.ResultSet_.staticClass, "getString", "(I)Ljava/lang/String;", ref global::java.sql.ResultSet_._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		bool java.sql.ResultSet.isFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSet_.staticClass, "isFirst", "()Z", ref global::java.sql.ResultSet_._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		global::java.sql.Time java.sql.ResultSet.getTime(java.lang.String arg0, java.util.Calendar arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getTime", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Time;", ref global::java.sql.ResultSet_._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.Time;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		global::java.sql.Time java.sql.ResultSet.getTime(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getTime", "(Ljava/lang/String;)Ljava/sql/Time;", ref global::java.sql.ResultSet_._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Time;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		global::java.sql.Time java.sql.ResultSet.getTime(int arg0, java.util.Calendar arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getTime", "(ILjava/util/Calendar;)Ljava/sql/Time;", ref global::java.sql.ResultSet_._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.Time;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		global::java.sql.Time java.sql.ResultSet.getTime(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getTime", "(I)Ljava/sql/Time;", ref global::java.sql.ResultSet_._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Time;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		global::java.sql.Date java.sql.ResultSet.getDate(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getDate", "(Ljava/lang/String;)Ljava/sql/Date;", ref global::java.sql.ResultSet_._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Date;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		global::java.sql.Date java.sql.ResultSet.getDate(java.lang.String arg0, java.util.Calendar arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getDate", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Date;", ref global::java.sql.ResultSet_._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.Date;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		global::java.sql.Date java.sql.ResultSet.getDate(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getDate", "(I)Ljava/sql/Date;", ref global::java.sql.ResultSet_._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Date;
		}
		private static global::MonoJavaBridge.MethodId _m40;
		global::java.sql.Date java.sql.ResultSet.getDate(int arg0, java.util.Calendar arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getDate", "(ILjava/util/Calendar;)Ljava/sql/Date;", ref global::java.sql.ResultSet_._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.Date;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		bool java.sql.ResultSet.isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSet_.staticClass, "isClosed", "()Z", ref global::java.sql.ResultSet_._m41);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getTimestamp", "(Ljava/lang/String;)Ljava/sql/Timestamp;", ref global::java.sql.ResultSet_._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Timestamp;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(int arg0, java.util.Calendar arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getTimestamp", "(ILjava/util/Calendar;)Ljava/sql/Timestamp;", ref global::java.sql.ResultSet_._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.Timestamp;
		}
		private static global::MonoJavaBridge.MethodId _m44;
		global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(java.lang.String arg0, java.util.Calendar arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getTimestamp", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Timestamp;", ref global::java.sql.ResultSet_._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.Timestamp;
		}
		private static global::MonoJavaBridge.MethodId _m45;
		global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getTimestamp", "(I)Ljava/sql/Timestamp;", ref global::java.sql.ResultSet_._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Timestamp;
		}
		private static global::MonoJavaBridge.MethodId _m46;
		bool java.sql.ResultSet.last()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSet_.staticClass, "last", "()Z", ref global::java.sql.ResultSet_._m46);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		bool java.sql.ResultSet.first()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSet_.staticClass, "first", "()Z", ref global::java.sql.ResultSet_._m47);
		}
		private static global::MonoJavaBridge.MethodId _m48;
		void java.sql.ResultSet.updateBytes(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateBytes", "(Ljava/lang/String;[B)V", ref global::java.sql.ResultSet_._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		void java.sql.ResultSet.updateBytes(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateBytes", "(I[B)V", ref global::java.sql.ResultSet_._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		bool java.sql.ResultSet.isLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSet_.staticClass, "isLast", "()Z", ref global::java.sql.ResultSet_._m50);
		}
		private static global::MonoJavaBridge.MethodId _m51;
		bool java.sql.ResultSet.isBeforeFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSet_.staticClass, "isBeforeFirst", "()Z", ref global::java.sql.ResultSet_._m51);
		}
		private static global::MonoJavaBridge.MethodId _m52;
		bool java.sql.ResultSet.isAfterLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSet_.staticClass, "isAfterLast", "()Z", ref global::java.sql.ResultSet_._m52);
		}
		private static global::MonoJavaBridge.MethodId _m53;
		global::java.sql.Blob java.sql.ResultSet.getBlob(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Blob>(this, global::java.sql.ResultSet_.staticClass, "getBlob", "(Ljava/lang/String;)Ljava/sql/Blob;", ref global::java.sql.ResultSet_._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Blob;
		}
		private static global::MonoJavaBridge.MethodId _m54;
		global::java.sql.Blob java.sql.ResultSet.getBlob(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Blob>(this, global::java.sql.ResultSet_.staticClass, "getBlob", "(I)Ljava/sql/Blob;", ref global::java.sql.ResultSet_._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Blob;
		}
		private static global::MonoJavaBridge.MethodId _m55;
		void java.sql.ResultSet.updateDate(int arg0, java.sql.Date arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateDate", "(ILjava/sql/Date;)V", ref global::java.sql.ResultSet_._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		void java.sql.ResultSet.updateDate(java.lang.String arg0, java.sql.Date arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateDate", "(Ljava/lang/String;Ljava/sql/Date;)V", ref global::java.sql.ResultSet_._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		void java.sql.ResultSet.updateTime(int arg0, java.sql.Time arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateTime", "(ILjava/sql/Time;)V", ref global::java.sql.ResultSet_._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		void java.sql.ResultSet.updateTime(java.lang.String arg0, java.sql.Time arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateTime", "(Ljava/lang/String;Ljava/sql/Time;)V", ref global::java.sql.ResultSet_._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		void java.sql.ResultSet.deleteRow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "deleteRow", "()V", ref global::java.sql.ResultSet_._m59);
		}
		private static global::MonoJavaBridge.MethodId _m60;
		void java.sql.ResultSet.updateBlob(java.lang.String arg0, java.sql.Blob arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V", ref global::java.sql.ResultSet_._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		void java.sql.ResultSet.updateBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V", ref global::java.sql.ResultSet_._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m62;
		void java.sql.ResultSet.updateBlob(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateBlob", "(ILjava/io/InputStream;)V", ref global::java.sql.ResultSet_._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		void java.sql.ResultSet.updateBlob(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateBlob", "(ILjava/io/InputStream;J)V", ref global::java.sql.ResultSet_._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		void java.sql.ResultSet.updateBlob(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V", ref global::java.sql.ResultSet_._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		void java.sql.ResultSet.updateBlob(int arg0, java.sql.Blob arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateBlob", "(ILjava/sql/Blob;)V", ref global::java.sql.ResultSet_._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		void java.sql.ResultSet.updateDouble(int arg0, double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateDouble", "(ID)V", ref global::java.sql.ResultSet_._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		void java.sql.ResultSet.updateDouble(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateDouble", "(Ljava/lang/String;D)V", ref global::java.sql.ResultSet_._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		void java.sql.ResultSet.updateFloat(java.lang.String arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateFloat", "(Ljava/lang/String;F)V", ref global::java.sql.ResultSet_._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		void java.sql.ResultSet.updateFloat(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateFloat", "(IF)V", ref global::java.sql.ResultSet_._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		void java.sql.ResultSet.updateInt(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateInt", "(Ljava/lang/String;I)V", ref global::java.sql.ResultSet_._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m71;
		void java.sql.ResultSet.updateInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateInt", "(II)V", ref global::java.sql.ResultSet_._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m72;
		void java.sql.ResultSet.updateLong(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateLong", "(Ljava/lang/String;J)V", ref global::java.sql.ResultSet_._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m73;
		void java.sql.ResultSet.updateLong(int arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateLong", "(IJ)V", ref global::java.sql.ResultSet_._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m74;
		void java.sql.ResultSet.updateShort(int arg0, short arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateShort", "(IS)V", ref global::java.sql.ResultSet_._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m75;
		void java.sql.ResultSet.updateShort(java.lang.String arg0, short arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateShort", "(Ljava/lang/String;S)V", ref global::java.sql.ResultSet_._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m76;
		void java.sql.ResultSet.updateString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateString", "(ILjava/lang/String;)V", ref global::java.sql.ResultSet_._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m77;
		void java.sql.ResultSet.updateString(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateString", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::java.sql.ResultSet_._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m78;
		bool java.sql.ResultSet.wasNull()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSet_.staticClass, "wasNull", "()Z", ref global::java.sql.ResultSet_._m78);
		}
		private static global::MonoJavaBridge.MethodId _m79;
		global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getBigDecimal", "(II)Ljava/math/BigDecimal;", ref global::java.sql.ResultSet_._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m80;
		global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getBigDecimal", "(I)Ljava/math/BigDecimal;", ref global::java.sql.ResultSet_._m80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m81;
		global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;", ref global::java.sql.ResultSet_._m81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m82;
		global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getBigDecimal", "(Ljava/lang/String;I)Ljava/math/BigDecimal;", ref global::java.sql.ResultSet_._m82, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m83;
		global::java.io.InputStream java.sql.ResultSet.getAsciiStream(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getAsciiStream", "(Ljava/lang/String;)Ljava/io/InputStream;", ref global::java.sql.ResultSet_._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m84;
		global::java.io.InputStream java.sql.ResultSet.getAsciiStream(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getAsciiStream", "(I)Ljava/io/InputStream;", ref global::java.sql.ResultSet_._m84, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m85;
		global::java.io.InputStream java.sql.ResultSet.getUnicodeStream(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getUnicodeStream", "(Ljava/lang/String;)Ljava/io/InputStream;", ref global::java.sql.ResultSet_._m85, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m86;
		global::java.io.InputStream java.sql.ResultSet.getUnicodeStream(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getUnicodeStream", "(I)Ljava/io/InputStream;", ref global::java.sql.ResultSet_._m86, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m87;
		global::java.io.InputStream java.sql.ResultSet.getBinaryStream(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getBinaryStream", "(I)Ljava/io/InputStream;", ref global::java.sql.ResultSet_._m87, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m88;
		global::java.io.InputStream java.sql.ResultSet.getBinaryStream(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getBinaryStream", "(Ljava/lang/String;)Ljava/io/InputStream;", ref global::java.sql.ResultSet_._m88, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m89;
		global::java.sql.SQLWarning java.sql.ResultSet.getWarnings()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;", ref global::java.sql.ResultSet_._m89) as java.sql.SQLWarning;
		}
		private static global::MonoJavaBridge.MethodId _m90;
		void java.sql.ResultSet.clearWarnings()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "clearWarnings", "()V", ref global::java.sql.ResultSet_._m90);
		}
		private static global::MonoJavaBridge.MethodId _m91;
		global::java.lang.String java.sql.ResultSet.getCursorName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.ResultSet_.staticClass, "getCursorName", "()Ljava/lang/String;", ref global::java.sql.ResultSet_._m91) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m92;
		global::java.sql.ResultSetMetaData java.sql.ResultSet.getMetaData()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSetMetaData>(this, global::java.sql.ResultSet_.staticClass, "getMetaData", "()Ljava/sql/ResultSetMetaData;", ref global::java.sql.ResultSet_._m92) as java.sql.ResultSetMetaData;
		}
		private static global::MonoJavaBridge.MethodId _m93;
		int java.sql.ResultSet.findColumn(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ResultSet_.staticClass, "findColumn", "(Ljava/lang/String;)I", ref global::java.sql.ResultSet_._m93, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m94;
		global::java.io.Reader java.sql.ResultSet.getCharacterStream(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;", ref global::java.sql.ResultSet_._m94, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.Reader;
		}
		private static global::MonoJavaBridge.MethodId _m95;
		global::java.io.Reader java.sql.ResultSet.getCharacterStream(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getCharacterStream", "(I)Ljava/io/Reader;", ref global::java.sql.ResultSet_._m95, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.Reader;
		}
		private static global::MonoJavaBridge.MethodId _m96;
		void java.sql.ResultSet.beforeFirst()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "beforeFirst", "()V", ref global::java.sql.ResultSet_._m96);
		}
		private static global::MonoJavaBridge.MethodId _m97;
		void java.sql.ResultSet.afterLast()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "afterLast", "()V", ref global::java.sql.ResultSet_._m97);
		}
		private static global::MonoJavaBridge.MethodId _m98;
		int java.sql.ResultSet.getRow()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ResultSet_.staticClass, "getRow", "()I", ref global::java.sql.ResultSet_._m98);
		}
		private static global::MonoJavaBridge.MethodId _m99;
		bool java.sql.ResultSet.absolute(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSet_.staticClass, "absolute", "(I)Z", ref global::java.sql.ResultSet_._m99, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m100;
		bool java.sql.ResultSet.relative(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSet_.staticClass, "relative", "(I)Z", ref global::java.sql.ResultSet_._m100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m101;
		void java.sql.ResultSet.setFetchDirection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "setFetchDirection", "(I)V", ref global::java.sql.ResultSet_._m101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m102;
		int java.sql.ResultSet.getFetchDirection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ResultSet_.staticClass, "getFetchDirection", "()I", ref global::java.sql.ResultSet_._m102);
		}
		private static global::MonoJavaBridge.MethodId _m103;
		void java.sql.ResultSet.setFetchSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "setFetchSize", "(I)V", ref global::java.sql.ResultSet_._m103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m104;
		int java.sql.ResultSet.getFetchSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ResultSet_.staticClass, "getFetchSize", "()I", ref global::java.sql.ResultSet_._m104);
		}
		private static global::MonoJavaBridge.MethodId _m105;
		int java.sql.ResultSet.getConcurrency()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ResultSet_.staticClass, "getConcurrency", "()I", ref global::java.sql.ResultSet_._m105);
		}
		private static global::MonoJavaBridge.MethodId _m106;
		bool java.sql.ResultSet.rowUpdated()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSet_.staticClass, "rowUpdated", "()Z", ref global::java.sql.ResultSet_._m106);
		}
		private static global::MonoJavaBridge.MethodId _m107;
		bool java.sql.ResultSet.rowInserted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSet_.staticClass, "rowInserted", "()Z", ref global::java.sql.ResultSet_._m107);
		}
		private static global::MonoJavaBridge.MethodId _m108;
		bool java.sql.ResultSet.rowDeleted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.ResultSet_.staticClass, "rowDeleted", "()Z", ref global::java.sql.ResultSet_._m108);
		}
		private static global::MonoJavaBridge.MethodId _m109;
		void java.sql.ResultSet.updateNull(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateNull", "(Ljava/lang/String;)V", ref global::java.sql.ResultSet_._m109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m110;
		void java.sql.ResultSet.updateNull(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateNull", "(I)V", ref global::java.sql.ResultSet_._m110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m111;
		void java.sql.ResultSet.updateBoolean(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateBoolean", "(IZ)V", ref global::java.sql.ResultSet_._m111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m112;
		void java.sql.ResultSet.updateBoolean(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateBoolean", "(Ljava/lang/String;Z)V", ref global::java.sql.ResultSet_._m112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m113;
		void java.sql.ResultSet.updateByte(int arg0, byte arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateByte", "(IB)V", ref global::java.sql.ResultSet_._m113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m114;
		void java.sql.ResultSet.updateByte(java.lang.String arg0, byte arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateByte", "(Ljava/lang/String;B)V", ref global::java.sql.ResultSet_._m114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m115;
		void java.sql.ResultSet.updateBigDecimal(int arg0, java.math.BigDecimal arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateBigDecimal", "(ILjava/math/BigDecimal;)V", ref global::java.sql.ResultSet_._m115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m116;
		void java.sql.ResultSet.updateBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V", ref global::java.sql.ResultSet_._m116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m117;
		void java.sql.ResultSet.updateTimestamp(java.lang.String arg0, java.sql.Timestamp arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V", ref global::java.sql.ResultSet_._m117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m118;
		void java.sql.ResultSet.updateTimestamp(int arg0, java.sql.Timestamp arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateTimestamp", "(ILjava/sql/Timestamp;)V", ref global::java.sql.ResultSet_._m118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m119;
		void java.sql.ResultSet.updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", ref global::java.sql.ResultSet_._m119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m120;
		void java.sql.ResultSet.updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V", ref global::java.sql.ResultSet_._m120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m121;
		void java.sql.ResultSet.updateAsciiStream(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateAsciiStream", "(ILjava/io/InputStream;J)V", ref global::java.sql.ResultSet_._m121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m122;
		void java.sql.ResultSet.updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", ref global::java.sql.ResultSet_._m122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m123;
		void java.sql.ResultSet.updateAsciiStream(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateAsciiStream", "(ILjava/io/InputStream;)V", ref global::java.sql.ResultSet_._m123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m124;
		void java.sql.ResultSet.updateAsciiStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateAsciiStream", "(ILjava/io/InputStream;I)V", ref global::java.sql.ResultSet_._m124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m125;
		void java.sql.ResultSet.updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", ref global::java.sql.ResultSet_._m125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m126;
		void java.sql.ResultSet.updateBinaryStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateBinaryStream", "(ILjava/io/InputStream;I)V", ref global::java.sql.ResultSet_._m126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m127;
		void java.sql.ResultSet.updateBinaryStream(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateBinaryStream", "(ILjava/io/InputStream;J)V", ref global::java.sql.ResultSet_._m127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m128;
		void java.sql.ResultSet.updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V", ref global::java.sql.ResultSet_._m128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m129;
		void java.sql.ResultSet.updateBinaryStream(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateBinaryStream", "(ILjava/io/InputStream;)V", ref global::java.sql.ResultSet_._m129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m130;
		void java.sql.ResultSet.updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", ref global::java.sql.ResultSet_._m130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m131;
		void java.sql.ResultSet.updateCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V", ref global::java.sql.ResultSet_._m131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m132;
		void java.sql.ResultSet.updateCharacterStream(int arg0, java.io.Reader arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateCharacterStream", "(ILjava/io/Reader;I)V", ref global::java.sql.ResultSet_._m132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m133;
		void java.sql.ResultSet.updateCharacterStream(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateCharacterStream", "(ILjava/io/Reader;J)V", ref global::java.sql.ResultSet_._m133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m134;
		void java.sql.ResultSet.updateCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", ref global::java.sql.ResultSet_._m134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m135;
		void java.sql.ResultSet.updateCharacterStream(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateCharacterStream", "(ILjava/io/Reader;)V", ref global::java.sql.ResultSet_._m135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m136;
		void java.sql.ResultSet.updateCharacterStream(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", ref global::java.sql.ResultSet_._m136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m137;
		void java.sql.ResultSet.updateObject(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateObject", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::java.sql.ResultSet_._m137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m138;
		void java.sql.ResultSet.updateObject(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateObject", "(ILjava/lang/Object;)V", ref global::java.sql.ResultSet_._m138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m139;
		void java.sql.ResultSet.updateObject(int arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateObject", "(ILjava/lang/Object;I)V", ref global::java.sql.ResultSet_._m139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m140;
		void java.sql.ResultSet.updateObject(java.lang.String arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateObject", "(Ljava/lang/String;Ljava/lang/Object;I)V", ref global::java.sql.ResultSet_._m140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m141;
		void java.sql.ResultSet.insertRow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "insertRow", "()V", ref global::java.sql.ResultSet_._m141);
		}
		private static global::MonoJavaBridge.MethodId _m142;
		void java.sql.ResultSet.updateRow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateRow", "()V", ref global::java.sql.ResultSet_._m142);
		}
		private static global::MonoJavaBridge.MethodId _m143;
		void java.sql.ResultSet.refreshRow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "refreshRow", "()V", ref global::java.sql.ResultSet_._m143);
		}
		private static global::MonoJavaBridge.MethodId _m144;
		void java.sql.ResultSet.cancelRowUpdates()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "cancelRowUpdates", "()V", ref global::java.sql.ResultSet_._m144);
		}
		private static global::MonoJavaBridge.MethodId _m145;
		void java.sql.ResultSet.moveToInsertRow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "moveToInsertRow", "()V", ref global::java.sql.ResultSet_._m145);
		}
		private static global::MonoJavaBridge.MethodId _m146;
		void java.sql.ResultSet.moveToCurrentRow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "moveToCurrentRow", "()V", ref global::java.sql.ResultSet_._m146);
		}
		private static global::MonoJavaBridge.MethodId _m147;
		global::java.sql.Statement java.sql.ResultSet.getStatement()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Statement>(this, global::java.sql.ResultSet_.staticClass, "getStatement", "()Ljava/sql/Statement;", ref global::java.sql.ResultSet_._m147) as java.sql.Statement;
		}
		private static global::MonoJavaBridge.MethodId _m148;
		global::java.sql.Clob java.sql.ResultSet.getClob(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Clob>(this, global::java.sql.ResultSet_.staticClass, "getClob", "(Ljava/lang/String;)Ljava/sql/Clob;", ref global::java.sql.ResultSet_._m148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Clob;
		}
		private static global::MonoJavaBridge.MethodId _m149;
		global::java.sql.Clob java.sql.ResultSet.getClob(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Clob>(this, global::java.sql.ResultSet_.staticClass, "getClob", "(I)Ljava/sql/Clob;", ref global::java.sql.ResultSet_._m149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Clob;
		}
		private static global::MonoJavaBridge.MethodId _m150;
		void java.sql.ResultSet.updateRef(java.lang.String arg0, java.sql.Ref arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateRef", "(Ljava/lang/String;Ljava/sql/Ref;)V", ref global::java.sql.ResultSet_._m150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m151;
		void java.sql.ResultSet.updateRef(int arg0, java.sql.Ref arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateRef", "(ILjava/sql/Ref;)V", ref global::java.sql.ResultSet_._m151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m152;
		void java.sql.ResultSet.updateClob(java.lang.String arg0, java.sql.Clob arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateClob", "(Ljava/lang/String;Ljava/sql/Clob;)V", ref global::java.sql.ResultSet_._m152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m153;
		void java.sql.ResultSet.updateClob(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateClob", "(ILjava/io/Reader;)V", ref global::java.sql.ResultSet_._m153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m154;
		void java.sql.ResultSet.updateClob(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateClob", "(Ljava/lang/String;Ljava/io/Reader;)V", ref global::java.sql.ResultSet_._m154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m155;
		void java.sql.ResultSet.updateClob(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateClob", "(ILjava/io/Reader;J)V", ref global::java.sql.ResultSet_._m155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m156;
		void java.sql.ResultSet.updateClob(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", ref global::java.sql.ResultSet_._m156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m157;
		void java.sql.ResultSet.updateClob(int arg0, java.sql.Clob arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateClob", "(ILjava/sql/Clob;)V", ref global::java.sql.ResultSet_._m157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m158;
		void java.sql.ResultSet.updateArray(int arg0, java.sql.Array arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateArray", "(ILjava/sql/Array;)V", ref global::java.sql.ResultSet_._m158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m159;
		void java.sql.ResultSet.updateArray(java.lang.String arg0, java.sql.Array arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateArray", "(Ljava/lang/String;Ljava/sql/Array;)V", ref global::java.sql.ResultSet_._m159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m160;
		int java.sql.ResultSet.getHoldability()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.ResultSet_.staticClass, "getHoldability", "()I", ref global::java.sql.ResultSet_._m160);
		}
		private static global::MonoJavaBridge.MethodId _m161;
		void java.sql.ResultSet.updateNString(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateNString", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::java.sql.ResultSet_._m161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m162;
		void java.sql.ResultSet.updateNString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateNString", "(ILjava/lang/String;)V", ref global::java.sql.ResultSet_._m162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m163;
		void java.sql.ResultSet.updateNClob(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateNClob", "(ILjava/io/Reader;)V", ref global::java.sql.ResultSet_._m163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m164;
		void java.sql.ResultSet.updateNClob(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateNClob", "(ILjava/io/Reader;J)V", ref global::java.sql.ResultSet_._m164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m165;
		void java.sql.ResultSet.updateNClob(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", ref global::java.sql.ResultSet_._m165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m166;
		void java.sql.ResultSet.updateNClob(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateNClob", "(Ljava/lang/String;Ljava/io/Reader;)V", ref global::java.sql.ResultSet_._m166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m167;
		global::java.lang.String java.sql.ResultSet.getNString(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.ResultSet_.staticClass, "getNString", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.sql.ResultSet_._m167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m168;
		global::java.lang.String java.sql.ResultSet.getNString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.ResultSet_.staticClass, "getNString", "(I)Ljava/lang/String;", ref global::java.sql.ResultSet_._m168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m169;
		global::java.io.Reader java.sql.ResultSet.getNCharacterStream(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getNCharacterStream", "(I)Ljava/io/Reader;", ref global::java.sql.ResultSet_._m169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.Reader;
		}
		private static global::MonoJavaBridge.MethodId _m170;
		global::java.io.Reader java.sql.ResultSet.getNCharacterStream(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.ResultSet_.staticClass, "getNCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;", ref global::java.sql.ResultSet_._m170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.Reader;
		}
		private static global::MonoJavaBridge.MethodId _m171;
		void java.sql.ResultSet.updateNCharacterStream(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateNCharacterStream", "(ILjava/io/Reader;)V", ref global::java.sql.ResultSet_._m171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m172;
		void java.sql.ResultSet.updateNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", ref global::java.sql.ResultSet_._m172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m173;
		void java.sql.ResultSet.updateNCharacterStream(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateNCharacterStream", "(ILjava/io/Reader;J)V", ref global::java.sql.ResultSet_._m173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m174;
		void java.sql.ResultSet.updateNCharacterStream(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.ResultSet_.staticClass, "updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", ref global::java.sql.ResultSet_._m174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static ResultSet_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.ResultSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/ResultSet"));
		}
	}
}
